namespace SysPandemic
{
    partial class AddPatient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idpatient_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.idperson_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tworkpatient_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.celpatient_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telpatient_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addresspatient_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sexpatient_cb = new System.Windows.Forms.ComboBox();
            this.bdaypatient_dtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namepatient_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.affiliatepatient_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.insurancepatient_txt = new System.Windows.Forms.ComboBox();
            this.delatepatient_btn = new System.Windows.Forms.Button();
            this.updatepatient_btn = new System.Windows.Forms.Button();
            this.savepatient_txt = new System.Windows.Forms.Button();
            this.clearform_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.printpatient_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idpatient_txt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.idperson_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tworkpatient_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.celpatient_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.telpatient_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addresspatient_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sexpatient_cb);
            this.groupBox1.Controls.Add(this.bdaypatient_dtp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.namepatient_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // idpatient_txt
            // 
            this.idpatient_txt.Enabled = false;
            this.idpatient_txt.Location = new System.Drawing.Point(42, 19);
            this.idpatient_txt.Name = "idpatient_txt";
            this.idpatient_txt.Size = new System.Drawing.Size(67, 20);
            this.idpatient_txt.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "ID:";
            // 
            // idperson_txt
            // 
            this.idperson_txt.Location = new System.Drawing.Point(403, 71);
            this.idperson_txt.Name = "idperson_txt";
            this.idperson_txt.Size = new System.Drawing.Size(143, 20);
            this.idperson_txt.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cédula:";
            // 
            // tworkpatient_txt
            // 
            this.tworkpatient_txt.Location = new System.Drawing.Point(424, 129);
            this.tworkpatient_txt.Name = "tworkpatient_txt";
            this.tworkpatient_txt.Size = new System.Drawing.Size(122, 20);
            this.tworkpatient_txt.TabIndex = 13;
            this.tworkpatient_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Trabajo:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // celpatient_txt
            // 
            this.celpatient_txt.Location = new System.Drawing.Point(248, 129);
            this.celpatient_txt.Name = "celpatient_txt";
            this.celpatient_txt.Size = new System.Drawing.Size(122, 20);
            this.celpatient_txt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Celular:";
            // 
            // telpatient_txt
            // 
            this.telpatient_txt.Location = new System.Drawing.Point(73, 129);
            this.telpatient_txt.Name = "telpatient_txt";
            this.telpatient_txt.Size = new System.Drawing.Size(122, 20);
            this.telpatient_txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono:";
            // 
            // addresspatient_txt
            // 
            this.addresspatient_txt.Location = new System.Drawing.Point(76, 98);
            this.addresspatient_txt.Name = "addresspatient_txt";
            this.addresspatient_txt.Size = new System.Drawing.Size(470, 20);
            this.addresspatient_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sexo:";
            // 
            // sexpatient_cb
            // 
            this.sexpatient_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexpatient_cb.FormattingEnabled = true;
            this.sexpatient_cb.Items.AddRange(new object[] {
            "",
            "M",
            "F"});
            this.sexpatient_cb.Location = new System.Drawing.Point(295, 71);
            this.sexpatient_cb.Name = "sexpatient_cb";
            this.sexpatient_cb.Size = new System.Drawing.Size(47, 21);
            this.sexpatient_cb.TabIndex = 4;
            // 
            // bdaypatient_dtp
            // 
            this.bdaypatient_dtp.CustomFormat = "dd/MM/yyyy";
            this.bdaypatient_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdaypatient_dtp.Location = new System.Drawing.Point(130, 68);
            this.bdaypatient_dtp.Name = "bdaypatient_dtp";
            this.bdaypatient_dtp.Size = new System.Drawing.Size(100, 20);
            this.bdaypatient_dtp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y Apellidos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // namepatient_txt
            // 
            this.namepatient_txt.Location = new System.Drawing.Point(121, 42);
            this.namepatient_txt.Name = "namepatient_txt";
            this.namepatient_txt.Size = new System.Drawing.Size(320, 20);
            this.namepatient_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información del paciente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.affiliatepatient_txt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.insurancepatient_txt);
            this.groupBox2.Location = new System.Drawing.Point(13, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de seguro:";
            // 
            // affiliatepatient_txt
            // 
            this.affiliatepatient_txt.Location = new System.Drawing.Point(247, 24);
            this.affiliatepatient_txt.Name = "affiliatepatient_txt";
            this.affiliatepatient_txt.Size = new System.Drawing.Size(122, 20);
            this.affiliatepatient_txt.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Afiliado #:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Seguro:";
            // 
            // insurancepatient_txt
            // 
            this.insurancepatient_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insurancepatient_txt.FormattingEnabled = true;
            this.insurancepatient_txt.Items.AddRange(new object[] {
            "",
            "Palic Salud",
            "ARS Humano",
            "Monumental de seguros"});
            this.insurancepatient_txt.Location = new System.Drawing.Point(56, 24);
            this.insurancepatient_txt.Name = "insurancepatient_txt";
            this.insurancepatient_txt.Size = new System.Drawing.Size(127, 21);
            this.insurancepatient_txt.TabIndex = 16;
            // 
            // delatepatient_btn
            // 
            this.delatepatient_btn.Location = new System.Drawing.Point(52, 281);
            this.delatepatient_btn.Name = "delatepatient_btn";
            this.delatepatient_btn.Size = new System.Drawing.Size(75, 23);
            this.delatepatient_btn.TabIndex = 3;
            this.delatepatient_btn.Text = "Borrar";
            this.delatepatient_btn.UseVisualStyleBackColor = true;
            this.delatepatient_btn.Click += new System.EventHandler(this.delatepatient_btn_Click);
            // 
            // updatepatient_btn
            // 
            this.updatepatient_btn.Location = new System.Drawing.Point(133, 281);
            this.updatepatient_btn.Name = "updatepatient_btn";
            this.updatepatient_btn.Size = new System.Drawing.Size(75, 23);
            this.updatepatient_btn.TabIndex = 4;
            this.updatepatient_btn.Text = "Actualizar";
            this.updatepatient_btn.UseVisualStyleBackColor = true;
            this.updatepatient_btn.Click += new System.EventHandler(this.updatepatient_btn_Click);
            // 
            // savepatient_txt
            // 
            this.savepatient_txt.Location = new System.Drawing.Point(217, 281);
            this.savepatient_txt.Name = "savepatient_txt";
            this.savepatient_txt.Size = new System.Drawing.Size(75, 23);
            this.savepatient_txt.TabIndex = 5;
            this.savepatient_txt.Text = "Guardar";
            this.savepatient_txt.UseVisualStyleBackColor = true;
            this.savepatient_txt.Click += new System.EventHandler(this.savepatient_txt_Click);
            // 
            // clearform_btn
            // 
            this.clearform_btn.Location = new System.Drawing.Point(298, 281);
            this.clearform_btn.Name = "clearform_btn";
            this.clearform_btn.Size = new System.Drawing.Size(75, 23);
            this.clearform_btn.TabIndex = 6;
            this.clearform_btn.Text = "Limpiar";
            this.clearform_btn.UseVisualStyleBackColor = true;
            this.clearform_btn.Click += new System.EventHandler(this.clearform_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(384, 281);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // printpatient_btn
            // 
            this.printpatient_btn.Location = new System.Drawing.Point(502, 281);
            this.printpatient_btn.Name = "printpatient_btn";
            this.printpatient_btn.Size = new System.Drawing.Size(75, 23);
            this.printpatient_btn.TabIndex = 8;
            this.printpatient_btn.Text = "Imprimir";
            this.printpatient_btn.UseVisualStyleBackColor = true;
            this.printpatient_btn.Click += new System.EventHandler(this.printpatient_btn_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(591, 313);
            this.Controls.Add(this.printpatient_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.clearform_btn);
            this.Controls.Add(this.savepatient_txt);
            this.Controls.Add(this.updatepatient_btn);
            this.Controls.Add(this.delatepatient_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Paciente";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button delatepatient_btn;
        public System.Windows.Forms.Button updatepatient_btn;
        public System.Windows.Forms.Button savepatient_txt;
        public System.Windows.Forms.Button clearform_btn;
        public System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.Button printpatient_btn;
        public System.Windows.Forms.TextBox namepatient_txt;
        public System.Windows.Forms.TextBox tworkpatient_txt;
        public System.Windows.Forms.TextBox celpatient_txt;
        public System.Windows.Forms.TextBox telpatient_txt;
        public System.Windows.Forms.TextBox addresspatient_txt;
        public System.Windows.Forms.ComboBox sexpatient_cb;
        public System.Windows.Forms.DateTimePicker bdaypatient_dtp;
        public System.Windows.Forms.ComboBox insurancepatient_txt;
        public System.Windows.Forms.TextBox idperson_txt;
        public System.Windows.Forms.TextBox affiliatepatient_txt;
        public System.Windows.Forms.TextBox idpatient_txt;
    }
}