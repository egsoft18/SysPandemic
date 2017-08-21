namespace SysPandemic
{
    partial class emergencypatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idpaemer_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaddres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.labels = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpreap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcober = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprocedure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btncan = new System.Windows.Forms.Button();
            this.updatepa_btn = new System.Windows.Forms.Button();
            this.billpa_btn = new System.Windows.Forms.Button();
            this.deletepa_btn = new System.Windows.Forms.Button();
            this.seebill_btn = new System.Windows.Forms.Button();
            this.datetoday = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente Ambulante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idpaemer_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtaddres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbsex);
            this.groupBox1.Controls.Add(this.labels);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente";
            // 
            // idpaemer_txt
            // 
            this.idpaemer_txt.Location = new System.Drawing.Point(33, 31);
            this.idpaemer_txt.Name = "idpaemer_txt";
            this.idpaemer_txt.ReadOnly = true;
            this.idpaemer_txt.Size = new System.Drawing.Size(74, 20);
            this.idpaemer_txt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(255, 59);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(157, 20);
            this.txttel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtaddres
            // 
            this.txtaddres.Location = new System.Drawing.Point(63, 88);
            this.txtaddres.Name = "txtaddres";
            this.txtaddres.Size = new System.Drawing.Size(519, 20);
            this.txtaddres.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección:";
            // 
            // cmbsex
            // 
            this.cmbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsex.Location = new System.Drawing.Point(63, 59);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(121, 21);
            this.cmbsex.TabIndex = 5;
            // 
            // labels
            // 
            this.labels.AutoSize = true;
            this.labels.Location = new System.Drawing.Point(7, 62);
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(34, 13);
            this.labels.TabIndex = 4;
            this.labels.Text = "Sexo:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(254, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(276, 20);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre y Apellido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtptime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtpreap);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btncalc);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtcober);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtprecio);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtprocedure);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(15, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Procedimiento";
            // 
            // dtptime
            // 
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptime.Location = new System.Drawing.Point(509, 28);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(109, 20);
            this.dtptime.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha";
            // 
            // txtpreap
            // 
            this.txtpreap.Location = new System.Drawing.Point(348, 98);
            this.txtpreap.Name = "txtpreap";
            this.txtpreap.ReadOnly = true;
            this.txtpreap.Size = new System.Drawing.Size(154, 20);
            this.txtpreap.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "RD$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Precio a Pagar:";
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(145, 93);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 8;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "RD$";
            // 
            // txtcober
            // 
            this.txtcober.Location = new System.Drawing.Point(402, 59);
            this.txtcober.Name = "txtcober";
            this.txtcober.Size = new System.Drawing.Size(100, 20);
            this.txtcober.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cobertura:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "RD$:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(177, 59);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(122, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Precio del procedimiento:";
            // 
            // txtprocedure
            // 
            this.txtprocedure.Location = new System.Drawing.Point(93, 28);
            this.txtprocedure.Name = "txtprocedure";
            this.txtprocedure.Size = new System.Drawing.Size(365, 20);
            this.txtprocedure.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Procedimiento:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(12, 302);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(255, 302);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 4;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btncan
            // 
            this.btncan.Location = new System.Drawing.Point(564, 302);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(75, 23);
            this.btncan.TabIndex = 5;
            this.btncan.Text = "Cancelar";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // updatepa_btn
            // 
            this.updatepa_btn.Location = new System.Drawing.Point(93, 302);
            this.updatepa_btn.Name = "updatepa_btn";
            this.updatepa_btn.Size = new System.Drawing.Size(75, 23);
            this.updatepa_btn.TabIndex = 6;
            this.updatepa_btn.Text = "Actualizar";
            this.updatepa_btn.UseVisualStyleBackColor = true;
            this.updatepa_btn.Click += new System.EventHandler(this.updatepa_btn_Click);
            // 
            // billpa_btn
            // 
            this.billpa_btn.Location = new System.Drawing.Point(374, 302);
            this.billpa_btn.Name = "billpa_btn";
            this.billpa_btn.Size = new System.Drawing.Size(75, 23);
            this.billpa_btn.TabIndex = 7;
            this.billpa_btn.Text = "Facturar";
            this.billpa_btn.UseVisualStyleBackColor = true;
            this.billpa_btn.Click += new System.EventHandler(this.billpa_btn_Click);
            // 
            // deletepa_btn
            // 
            this.deletepa_btn.Location = new System.Drawing.Point(174, 302);
            this.deletepa_btn.Name = "deletepa_btn";
            this.deletepa_btn.Size = new System.Drawing.Size(75, 23);
            this.deletepa_btn.TabIndex = 8;
            this.deletepa_btn.Text = "Borrar";
            this.deletepa_btn.UseVisualStyleBackColor = true;
            this.deletepa_btn.Click += new System.EventHandler(this.deletepa_btn_Click);
            // 
            // seebill_btn
            // 
            this.seebill_btn.Location = new System.Drawing.Point(467, 302);
            this.seebill_btn.Name = "seebill_btn";
            this.seebill_btn.Size = new System.Drawing.Size(75, 23);
            this.seebill_btn.TabIndex = 9;
            this.seebill_btn.Text = "Ver factura";
            this.seebill_btn.UseVisualStyleBackColor = true;
            this.seebill_btn.Click += new System.EventHandler(this.seebill_btn_Click);
            // 
            // datetoday
            // 
            this.datetoday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetoday.Location = new System.Drawing.Point(255, 353);
            this.datetoday.Name = "datetoday";
            this.datetoday.Size = new System.Drawing.Size(109, 20);
            this.datetoday.TabIndex = 14;
            // 
            // emergencypatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(649, 333);
            this.Controls.Add(this.datetoday);
            this.Controls.Add(this.seebill_btn);
            this.Controls.Add(this.deletepa_btn);
            this.Controls.Add(this.billpa_btn);
            this.Controls.Add(this.updatepa_btn);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "emergencypatient";
            this.Text = "Paciente Ambulante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button updatepa_btn;
        public System.Windows.Forms.Button billpa_btn;
        public System.Windows.Forms.Button deletepa_btn;
        public System.Windows.Forms.ComboBox cmbsex;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txttel;
        public System.Windows.Forms.TextBox txtaddres;
        public System.Windows.Forms.TextBox txtprocedure;
        public System.Windows.Forms.TextBox txtpreap;
        public System.Windows.Forms.TextBox txtcober;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.DateTimePicker dtptime;
        public System.Windows.Forms.TextBox idpaemer_txt;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button seebill_btn;
        public System.Windows.Forms.DateTimePicker datetoday;
    }
}