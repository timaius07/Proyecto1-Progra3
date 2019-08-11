namespace MarcoCambroneroVAgendaSocial.GUI
{
    partial class FrmLoginFacebook
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
            this.wbFacebook = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbFacebook
            // 
            this.wbFacebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbFacebook.Location = new System.Drawing.Point(0, 0);
            this.wbFacebook.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFacebook.Name = "wbFacebook";
            this.wbFacebook.Size = new System.Drawing.Size(439, 321);
            this.wbFacebook.TabIndex = 0;
            this.wbFacebook.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.CambioPagina);
            // 
            // FrmLoginFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 321);
            this.Controls.Add(this.wbFacebook);
            this.Name = "FrmLoginFacebook";
            this.Text = "Inicio de Sesion Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLoginFacebook_FormClosing);
            this.Load += new System.EventHandler(this.FrmLoginFacebook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbFacebook;
    }
}