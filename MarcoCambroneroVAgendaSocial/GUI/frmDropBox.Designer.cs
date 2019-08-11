namespace MarcoCambroneroVAgendaSocial.GUI
{
    partial class frmDropBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDropBox));
            this.DropBox = new System.Windows.Forms.ListBox();
            this.btnUpFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // DropBox
            // 
            this.DropBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DropBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DropBox.FormattingEnabled = true;
            this.DropBox.Location = new System.Drawing.Point(6, 12);
            this.DropBox.Name = "DropBox";
            this.DropBox.Size = new System.Drawing.Size(224, 117);
            this.DropBox.TabIndex = 0;
            this.DropBox.DoubleClick += new System.EventHandler(this.listBox_Doubleclik);
            // 
            // btnUpFile
            // 
            this.btnUpFile.Image = global::MarcoCambroneroVAgendaSocial.Properties.Resources._1457697589_cloud_arrow_up;
            this.btnUpFile.Location = new System.Drawing.Point(185, 135);
            this.btnUpFile.Name = "btnUpFile";
            this.btnUpFile.Size = new System.Drawing.Size(45, 40);
            this.btnUpFile.TabIndex = 3;
            this.btnUpFile.UseVisualStyleBackColor = true;
            this.btnUpFile.Click += new System.EventHandler(this.btnUpFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDropBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.dropbox;
            this.ClientSize = new System.Drawing.Size(242, 220);
            this.Controls.Add(this.btnUpFile);
            this.Controls.Add(this.DropBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDropBox";
            this.Text = "Cargar Archivos DropBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDropBox_FormClosing);
            this.Load += new System.EventHandler(this.frmDropBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DropBox;
        private System.Windows.Forms.Button btnUpFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}