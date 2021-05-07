
namespace PdfHelper
{
    partial class FormAgrupar
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.buttonAgrupar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonDestino = new System.Windows.Forms.Button();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
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
            this.btnSelecionar.Location = new System.Drawing.Point(12, 12);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(550, 33);
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
            this.listViewFiles.Location = new System.Drawing.Point(12, 51);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(550, 216);
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
            this.buttonAgrupar.Location = new System.Drawing.Point(402, 314);
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
            this.buttonDestino.Location = new System.Drawing.Point(18, 273);
            this.buttonDestino.Name = "buttonDestino";
            this.buttonDestino.Size = new System.Drawing.Size(66, 24);
            this.buttonDestino.TabIndex = 4;
            this.buttonDestino.Text = "Destino";
            this.buttonDestino.UseVisualStyleBackColor = true;
            this.buttonDestino.Click += new System.EventHandler(this.buttonDestino_Click);
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(90, 273);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(472, 23);
            this.textBoxDestino.TabIndex = 5;
            // 
            // FormAgrupar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(574, 359);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.buttonDestino);
            this.Controls.Add(this.buttonAgrupar);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.btnSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgrupar";
            this.Text = "Agrupador de PDF";
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
    }
}

