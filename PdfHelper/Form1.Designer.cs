
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.PictureBox();
            this.btnMenuAgrupar = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnComprimir = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseWindow)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // btnMenuAgrupar
            // 
            this.btnMenuAgrupar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAgrupar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMenuAgrupar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMenuAgrupar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAgrupar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuAgrupar.ForeColor = System.Drawing.Color.White;
            this.btnMenuAgrupar.Location = new System.Drawing.Point(11, 14);
            this.btnMenuAgrupar.Name = "btnMenuAgrupar";
            this.btnMenuAgrupar.Size = new System.Drawing.Size(179, 44);
            this.btnMenuAgrupar.TabIndex = 0;
            this.btnMenuAgrupar.Text = "Agrupar";
            this.btnMenuAgrupar.UseVisualStyleBackColor = true;
            this.btnMenuAgrupar.Click += new System.EventHandler(this.btnMenuAgrupar_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.btnImage);
            this.PanelMenu.Controls.Add(this.btnComprimir);
            this.PanelMenu.Controls.Add(this.btnMenuAgrupar);
            this.PanelMenu.Location = new System.Drawing.Point(7, 37);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(201, 360);
            this.PanelMenu.TabIndex = 8;
            // 
            // btnComprimir
            // 
            this.btnComprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnComprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnComprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprimir.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComprimir.ForeColor = System.Drawing.Color.White;
            this.btnComprimir.Location = new System.Drawing.Point(11, 64);
            this.btnComprimir.Name = "btnComprimir";
            this.btnComprimir.Size = new System.Drawing.Size(179, 44);
            this.btnComprimir.TabIndex = 1;
            this.btnComprimir.Text = "Comprimir";
            this.btnComprimir.UseVisualStyleBackColor = true;
            this.btnComprimir.Click += new System.EventHandler(this.btnComprimir_Click);
            // 
            // panelBody
            // 
            this.panelBody.Location = new System.Drawing.Point(216, 37);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(574, 359);
            this.panelBody.TabIndex = 9;
            // 
            // btnImage
            // 
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(11, 114);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(179, 44);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "Imagem";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Agrupador de PDF";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseWindow)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnCloseWindow;
        private System.Windows.Forms.Button btnMenuAgrupar;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnComprimir;
        private System.Windows.Forms.Button btnImage;
    }
}

