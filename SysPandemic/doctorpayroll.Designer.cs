namespace SysPandemic
{
    partial class doctorpayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctorpayroll));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idpersondoctor_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namedoctor_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdDoctorPR_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateend_dtp = new System.Windows.Forms.DateTimePicker();
            this.datestart_dtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genpayroll_btn = new System.Windows.Forms.Button();
            this.topay_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idpersondoctor_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.namedoctor_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IdDoctorPR_txt);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del doctor";
            // 
            // idpersondoctor_txt
            // 
            this.idpersondoctor_txt.Location = new System.Drawing.Point(429, 28);
            this.idpersondoctor_txt.Name = "idpersondoctor_txt";
            this.idpersondoctor_txt.ReadOnly = true;
            this.idpersondoctor_txt.Size = new System.Drawing.Size(90, 20);
            this.idpersondoctor_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cedula:";
            // 
            // namedoctor_txt
            // 
            this.namedoctor_txt.Location = new System.Drawing.Point(117, 28);
            this.namedoctor_txt.Name = "namedoctor_txt";
            this.namedoctor_txt.ReadOnly = true;
            this.namedoctor_txt.Size = new System.Drawing.Size(257, 20);
            this.namedoctor_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor:";
            // 
            // IdDoctorPR_txt
            // 
            this.IdDoctorPR_txt.Location = new System.Drawing.Point(54, 28);
            this.IdDoctorPR_txt.Name = "IdDoctorPR_txt";
            this.IdDoctorPR_txt.ReadOnly = true;
            this.IdDoctorPR_txt.Size = new System.Drawing.Size(57, 20);
            this.IdDoctorPR_txt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateend_dtp);
            this.groupBox2.Controls.Add(this.datestart_dtp);
            this.groupBox2.Location = new System.Drawing.Point(13, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango a pagar:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de inicio:";
            // 
            // dateend_dtp
            // 
            this.dateend_dtp.CustomFormat = "yyyy-MM-dd";
            this.dateend_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateend_dtp.Location = new System.Drawing.Point(347, 19);
            this.dateend_dtp.Name = "dateend_dtp";
            this.dateend_dtp.Size = new System.Drawing.Size(94, 20);
            this.dateend_dtp.TabIndex = 1;
            this.dateend_dtp.ValueChanged += new System.EventHandler(this.dateend_dtp_ValueChanged);
            // 
            // datestart_dtp
            // 
            this.datestart_dtp.CustomFormat = "yyyy-MM-dd";
            this.datestart_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datestart_dtp.Location = new System.Drawing.Point(159, 19);
            this.datestart_dtp.Name = "datestart_dtp";
            this.datestart_dtp.Size = new System.Drawing.Size(94, 20);
            this.datestart_dtp.TabIndex = 0;
            this.datestart_dtp.ValueChanged += new System.EventHandler(this.datestart_dtp_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(525, 245);
            this.dataGridView1.TabIndex = 2;
            // 
            // genpayroll_btn
            // 
            this.genpayroll_btn.Location = new System.Drawing.Point(13, 436);
            this.genpayroll_btn.Name = "genpayroll_btn";
            this.genpayroll_btn.Size = new System.Drawing.Size(526, 23);
            this.genpayroll_btn.TabIndex = 3;
            this.genpayroll_btn.Text = "Generar Nomina";
            this.genpayroll_btn.UseVisualStyleBackColor = true;
            this.genpayroll_btn.Click += new System.EventHandler(this.genpayroll_btn_Click);
            // 
            // topay_txt
            // 
            this.topay_txt.Location = new System.Drawing.Point(410, 396);
            this.topay_txt.Name = "topay_txt";
            this.topay_txt.ReadOnly = true;
            this.topay_txt.Size = new System.Drawing.Size(128, 20);
            this.topay_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total a pagar:";
            // 
            // doctorpayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.topay_txt);
            this.Controls.Add(this.genpayroll_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "doctorpayroll";
            this.Text = "Nomina del Doctor";
            this.Activated += new System.EventHandler(this.doctorpayroll_Activated);
            this.Load += new System.EventHandler(this.doctorpayroll_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idpersondoctor_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namedoctor_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateend_dtp;
        private System.Windows.Forms.DateTimePicker datestart_dtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox IdDoctorPR_txt;
        private System.Windows.Forms.Button genpayroll_btn;
        private System.Windows.Forms.TextBox topay_txt;
        private System.Windows.Forms.Label label5;
    }
}