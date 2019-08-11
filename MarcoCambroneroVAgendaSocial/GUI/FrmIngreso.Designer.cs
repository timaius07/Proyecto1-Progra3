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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbHoraF = new System.Windows.Forms.ComboBox();
            this.cmbHoraI = new System.Windows.Forms.ComboBox();
            this.txtevento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.masktexHora2 = new System.Windows.Forms.MaskedTextBox();
            this.masktexHora1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedtextfecha = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.PicBoxImagen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Tan;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 147);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(143, 174);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 32);
            this.btnAgendar.TabIndex = 1;
            this.btnAgendar.Text = "Agendar Cita";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(201, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 18);
            this.lblFecha.TabIndex = 4;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(196, 99);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(0, 18);
            this.lblhora.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmbHoraF);
            this.panel1.Controls.Add(this.cmbHoraI);
            this.panel1.Controls.Add(this.txtevento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.masktexHora2);
            this.panel1.Controls.Add(this.masktexHora1);
            this.panel1.Controls.Add(this.maskedtextfecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAgendar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(257, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 215);
            this.panel1.TabIndex = 6;
            // 
            // cmbHoraF
            // 
            this.cmbHoraF.FormattingEnabled = true;
            this.cmbHoraF.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cmbHoraF.Location = new System.Drawing.Point(308, 127);
            this.cmbHoraF.Name = "cmbHoraF";
            this.cmbHoraF.Size = new System.Drawing.Size(46, 24);
            this.cmbHoraF.TabIndex = 9;
            // 
            // cmbHoraI
            // 
            this.cmbHoraI.FormattingEnabled = true;
            this.cmbHoraI.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cmbHoraI.Location = new System.Drawing.Point(308, 94);
            this.cmbHoraI.Name = "cmbHoraI";
            this.cmbHoraI.Size = new System.Drawing.Size(46, 24);
            this.cmbHoraI.TabIndex = 8;
            // 
            // txtevento
            // 
            this.txtevento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtevento.Location = new System.Drawing.Point(189, 6);
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
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre Evento:";
            // 
            // masktexHora2
            // 
            this.masktexHora2.Location = new System.Drawing.Point(189, 128);
            this.masktexHora2.Mask = "00:00";
            this.masktexHora2.Name = "masktexHora2";
            this.masktexHora2.Size = new System.Drawing.Size(113, 22);
            this.masktexHora2.TabIndex = 5;
            this.masktexHora2.ValidatingType = typeof(System.DateTime);
            // 
            // masktexHora1
            // 
            this.masktexHora1.Location = new System.Drawing.Point(189, 94);
            this.masktexHora1.Mask = "00:00";
            this.masktexHora1.Name = "masktexHora1";
            this.masktexHora1.Size = new System.Drawing.Size(113, 22);
            this.masktexHora1.TabIndex = 4;
            this.masktexHora1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedtextfecha
            // 
            this.maskedtextfecha.Location = new System.Drawing.Point(189, 58);
            this.maskedtextfecha.Mask = "00/00/0000";
            this.maskedtextfecha.Name = "maskedtextfecha";
            this.maskedtextfecha.Size = new System.Drawing.Size(113, 22);
            this.maskedtextfecha.TabIndex = 3;
            this.maskedtextfecha.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hora Final del Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora de Inicio del Evento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha del Evento:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.Agenda2;
            this.groupBox1.Controls.Add(this.lblCuenta);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lbUsuario);
            this.groupBox1.Controls.Add(this.lblhora);
            this.groupBox1.Controls.Add(this.PicBoxImagen);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(81, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mi cuenta:";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(132, 37);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(53, 17);
            this.lblCuenta.TabIndex = 6;
            this.lblCuenta.Text = "Cuenta";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(316, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 17);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "LBLID";
            this.lblId.Visible = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(131, 20);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 17);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario";
            // 
            // PicBoxImagen
            // 
            this.PicBoxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxImagen.Location = new System.Drawing.Point(6, 22);
            this.PicBoxImagen.Name = "PicBoxImagen";
            this.PicBoxImagen.Size = new System.Drawing.Size(105, 80);
            this.PicBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxImagen.TabIndex = 0;
            this.PicBoxImagen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.Agenda2;
            this.ClientSize = new System.Drawing.Size(644, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Social";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ingreso_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxImagen)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.PictureBox PicBoxImagen;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbHoraF;
        private System.Windows.Forms.ComboBox cmbHoraI;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Timer timer1;
    }
}

