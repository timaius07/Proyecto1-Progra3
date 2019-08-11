namespace MarcoCambroneroVAgendaSocial.GUI
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.Expire = new System.Windows.Forms.Label();
            this.RefreshToken = new System.Windows.Forms.Label();
            this.AccesToken = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Expire
            // 
            this.Expire.AutoSize = true;
            this.Expire.Location = new System.Drawing.Point(167, 281);
            this.Expire.Name = "Expire";
            this.Expire.Size = new System.Drawing.Size(0, 13);
            this.Expire.TabIndex = 8;
            // 
            // RefreshToken
            // 
            this.RefreshToken.AutoSize = true;
            this.RefreshToken.Location = new System.Drawing.Point(167, 254);
            this.RefreshToken.Name = "RefreshToken";
            this.RefreshToken.Size = new System.Drawing.Size(0, 13);
            this.RefreshToken.TabIndex = 7;
            // 
            // AccesToken
            // 
            this.AccesToken.AutoSize = true;
            this.AccesToken.Location = new System.Drawing.Point(197, 230);
            this.AccesToken.Name = "AccesToken";
            this.AccesToken.Size = new System.Drawing.Size(0, 13);
            this.AccesToken.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 46F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 81);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.google;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(58, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 61);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.FBlogin;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(58, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 61);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.Agenda2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Expire);
            this.Controls.Add(this.RefreshToken);
            this.Controls.Add(this.AccesToken);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de Inicio de Session";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Expire;
        private System.Windows.Forms.Label RefreshToken;
        private System.Windows.Forms.Label AccesToken;
        private System.Windows.Forms.Label label1;
    }
}