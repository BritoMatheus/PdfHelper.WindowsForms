
namespace PdfHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.buttonAgrupar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonDestino = new System.Windows.Forms.Button();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.Location = new System.Drawing.Point(12, 34);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(776, 33);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar arquivo(s)";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewFiles
            // 
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(12, 73);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(776, 256);
            this.listViewFiles.TabIndex = 2;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.List;
            // 
            // buttonAgrupar
            // 
            this.buttonAgrupar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgrupar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAgrupar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAgrupar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgrupar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAgrupar.ForeColor = System.Drawing.Color.White;
            this.buttonAgrupar.Location = new System.Drawing.Point(628, 365);
            this.buttonAgrupar.Name = "buttonAgrupar";
            this.buttonAgrupar.Size = new System.Drawing.Size(160, 33);
            this.buttonAgrupar.TabIndex = 3;
            this.buttonAgrupar.Text = "Agrupar";
            this.buttonAgrupar.UseVisualStyleBackColor = true;
            this.buttonAgrupar.Click += new System.EventHandler(this.buttonAgrupar_Click);
            // 
            // buttonDestino
            // 
            this.buttonDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDestino.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDestino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDestino.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDestino.ForeColor = System.Drawing.Color.White;
            this.buttonDestino.Location = new System.Drawing.Point(12, 335);
            this.buttonDestino.Name = "buttonDestino";
            this.buttonDestino.Size = new System.Drawing.Size(66, 24);
            this.buttonDestino.TabIndex = 4;
            this.buttonDestino.Text = "Destino";
            this.buttonDestino.UseVisualStyleBackColor = true;
            this.buttonDestino.Click += new System.EventHandler(this.buttonDestino_Click);
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(79, 336);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(703, 23);
            this.textBoxDestino.TabIndex = 5;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelTop.Controls.Add(this.btnCloseWindow);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 28);
            this.panelTop.TabIndex = 6;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindow.Image")));
            this.btnCloseWindow.Location = new System.Drawing.Point(754, -4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(47, 28);
            this.btnCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseWindow.TabIndex = 0;
            this.btnCloseWindow.TabStop = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.buttonDestino);
            this.Controls.Add(this.buttonAgrupar);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.btnSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Agrupador de PDF";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button buttonAgrupar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonDestino;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnCloseWindow;
    }
}

