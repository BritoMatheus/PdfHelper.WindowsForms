using Domain.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PdfHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Pdf Files|*.pdf";
            this.openFileDialog1.Multiselect = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (var file in openFileDialog1.FileNames)
                {
                    try
                    {
                        string text = File.ReadAllText(file);
                        if (file.Contains(".pdf") || file.Contains(".PDF"))
                            listViewFiles.Items.Add(file);
                    }
                    catch (IOException)
                    {
                    }
                }
            }
        }

        private void buttonAgrupar_Click(object sender, EventArgs e)
        {
            if (listViewFiles.Items.Count < 2)
            {
                MessageBox.Show("Selecione mais de 1 arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDestino.Text))
            {
                MessageBox.Show("Insira o destino!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> files = new List<string>();

            for (int i = 0; i < listViewFiles.Items.Count; i++)
            {
                files.Add(listViewFiles.Items[i].Text);
            }

            new PdfUtil().Agrupar(files, textBoxDestino.Text);
            MessageBox.Show("Arquivo gerado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //System.Diagnostics.Process.Start(outputPdfPath);
        }

        private void buttonDestino_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxDestino.Text = $"{folderBrowserDialog1.SelectedPath}\\merge.pdf";
            }
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
