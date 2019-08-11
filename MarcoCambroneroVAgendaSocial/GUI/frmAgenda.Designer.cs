namespace MarcoCambroneroVAgendaSocial.GUI
{
    partial class frmAgenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.dateTimeConsulta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.btnPostear = new System.Windows.Forms.Button();
            this.dataGridAgenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.PicBoxImagen = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeConsulta
            // 
            this.dateTimeConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeConsulta.Location = new System.Drawing.Point(389, 42);
            this.dateTimeConsulta.Name = "dateTimeConsulta";
            this.dateTimeConsulta.Size = new System.Drawing.Size(100, 24);
            this.dateTimeConsulta.TabIndex = 15;
            this.dateTimeConsulta.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataGridAgenda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeConsulta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 501);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Actividad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPost);
            this.groupBox3.Controls.Add(this.btnPostear);
            this.groupBox3.Location = new System.Drawing.Point(135, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 99);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compartir Evento";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(15, 53);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(224, 18);
            this.lblPost.TabIndex = 22;
            this.lblPost.Text = "Seleccione un Evento en Agenda";
            // 
            // btnPostear
            // 
            this.btnPostear.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.bot_shareFacebook;
            this.btnPostear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPostear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostear.Location = new System.Drawing.Point(382, 28);
            this.btnPostear.Name = "btnPostear";
            this.btnPostear.Size = new System.Drawing.Size(116, 43);
            this.btnPostear.TabIndex = 19;
            this.btnPostear.UseVisualStyleBackColor = true;
            this.btnPostear.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridAgenda
            // 
            this.dataGridAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAgenda.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAgenda.Location = new System.Drawing.Point(12, 72);
            this.dataGridAgenda.Name = "dataGridAgenda";
            this.dataGridAgenda.Size = new System.Drawing.Size(756, 263);
            this.dataGridAgenda.TabIndex = 17;
            this.dataGridAgenda.SelectionChanged += new System.EventHandler(this.dataGridAgenda_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione la Fecha de Consulta";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblCuenta);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.lbUsuario);
            this.groupBox2.Controls.Add(this.lblhora);
            this.groupBox2.Controls.Add(this.PicBoxImagen);
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(194, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 129);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mi cuenta:";
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
            this.lblId.Size = new System.Drawing.Size(62, 17);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Nombre ";
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
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(196, 99);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(0, 18);
            this.lblhora.TabIndex = 5;
            // 
            // PicBoxImagen
            // 
            this.PicBoxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxImagen.Location = new System.Drawing.Point(6, 20);
            this.PicBoxImagen.Name = "PicBoxImagen";
            this.PicBoxImagen.Size = new System.Drawing.Size(105, 80);
            this.PicBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxImagen.TabIndex = 0;
            this.PicBoxImagen.TabStop = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Repaldar Datos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.dropbox;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(768, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 50);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::MarcoCambroneroVAgendaSocial.Properties.Resources.Agenda2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgenda_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridAgenda;
        private System.Windows.Forms.Button btnPostear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.PictureBox PicBoxImagen;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPost;
    }
}