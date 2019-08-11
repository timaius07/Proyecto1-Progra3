namespace MarcoCambroneroVAgendaSocial
{
    partial class Ingreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtevento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.masktexHora2 = new System.Windows.Forms.MaskedTextBox();
            this.masktexHora1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedtextfecha = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Tan;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 119);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(240, 178);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 23);
            this.btnAgendar.TabIndex = 1;
            this.btnAgendar.Text = "Agendar Cita";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(97, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 4;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(97, 64);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(0, 13);
            this.lblhora.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtevento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.masktexHora2);
            this.panel1.Controls.Add(this.masktexHora1);
            this.panel1.Controls.Add(this.maskedtextfecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAgendar);
            this.panel1.Location = new System.Drawing.Point(257, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 215);
            this.panel1.TabIndex = 6;
            // 
            // txtevento
            // 
            this.txtevento.Location = new System.Drawing.Point(171, 5);
            this.txtevento.Multiline = true;
            this.txtevento.Name = "txtevento";
            this.txtevento.Size = new System.Drawing.Size(144, 46);
            this.txtevento.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre Evento:";
            // 
            // masktexHora2
            // 
            this.masktexHora2.Location = new System.Drawing.Point(171, 127);
            this.masktexHora2.Mask = "00:00";
            this.masktexHora2.Name = "masktexHora2";
            this.masktexHora2.Size = new System.Drawing.Size(113, 20);
            this.masktexHora2.TabIndex = 5;
            this.masktexHora2.ValidatingType = typeof(System.DateTime);
            // 
            // masktexHora1
            // 
            this.masktexHora1.Location = new System.Drawing.Point(171, 93);
            this.masktexHora1.Mask = "00:00";
            this.masktexHora1.Name = "masktexHora1";
            this.masktexHora1.Size = new System.Drawing.Size(113, 20);
            this.masktexHora1.TabIndex = 4;
            this.masktexHora1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedtextfecha
            // 
            this.maskedtextfecha.Location = new System.Drawing.Point(171, 57);
            this.maskedtextfecha.Mask = "00/00/0000";
            this.maskedtextfecha.Name = "maskedtextfecha";
            this.maskedtextfecha.Size = new System.Drawing.Size(113, 20);
            this.maskedtextfecha.TabIndex = 3;
            this.maskedtextfecha.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hora Final del Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora de Inicio del Evento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha del Evento:";
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(598, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Social";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox masktexHora1;
        private System.Windows.Forms.MaskedTextBox maskedtextfecha;
        private System.Windows.Forms.MaskedTextBox masktexHora2;
        private System.Windows.Forms.TextBox txtevento;
        private System.Windows.Forms.Label label6;
    }
}

