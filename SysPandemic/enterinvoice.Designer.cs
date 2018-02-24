namespace SysPandemic
{
    partial class enterinvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enterinvoice));
            this.nameprovider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchprovider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idprovider = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymeth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datebill = new System.Windows.Forms.DateTimePicker();
            this.reasonbill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nobill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.processinvoice = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.idonsys = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameprovider
            // 
            this.nameprovider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameprovider.Location = new System.Drawing.Point(151, 25);
            this.nameprovider.Name = "nameprovider";
            this.nameprovider.Size = new System.Drawing.Size(222, 20);
            this.nameprovider.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // searchprovider
            // 
            this.searchprovider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchprovider.Location = new System.Drawing.Point(379, 25);
            this.searchprovider.Name = "searchprovider";
            this.searchprovider.Size = new System.Drawing.Size(53, 26);
            this.searchprovider.TabIndex = 2;
            this.searchprovider.Text = "Buscar";
            this.searchprovider.UseVisualStyleBackColor = true;
            this.searchprovider.Click += new System.EventHandler(this.searchprovider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idprovider);
            this.groupBox1.Controls.Add(this.nameprovider);
            this.groupBox1.Controls.Add(this.searchprovider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Suplidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suplidor:";
            // 
            // idprovider
            // 
            this.idprovider.Enabled = false;
            this.idprovider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idprovider.Location = new System.Drawing.Point(34, 25);
            this.idprovider.Name = "idprovider";
            this.idprovider.Size = new System.Drawing.Size(49, 20);
            this.idprovider.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qty);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.paymeth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.datebill);
            this.groupBox2.Controls.Add(this.reasonbill);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nobill);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 122);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la factura";
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(280, 87);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(111, 20);
            this.qty.TabIndex = 13;
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Monto pagado: (RD$)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // paymeth
            // 
            this.paymeth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymeth.FormattingEnabled = true;
            this.paymeth.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Banco",
            "Cheque"});
            this.paymeth.Location = new System.Drawing.Point(58, 87);
            this.paymeth.Name = "paymeth";
            this.paymeth.Size = new System.Drawing.Size(84, 21);
            this.paymeth.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Origen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            // 
            // datebill
            // 
            this.datebill.CustomFormat = "yyyy-MM-dd";
            this.datebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebill.Location = new System.Drawing.Point(198, 37);
            this.datebill.Name = "datebill";
            this.datebill.Size = new System.Drawing.Size(95, 20);
            this.datebill.TabIndex = 8;
            // 
            // reasonbill
            // 
            this.reasonbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonbill.Location = new System.Drawing.Point(58, 63);
            this.reasonbill.Name = "reasonbill";
            this.reasonbill.Size = new System.Drawing.Size(374, 20);
            this.reasonbill.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Razon:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nobill
            // 
            this.nobill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobill.Location = new System.Drawing.Point(85, 37);
            this.nobill.Name = "nobill";
            this.nobill.Size = new System.Drawing.Size(60, 20);
            this.nobill.TabIndex = 5;
            this.nobill.Text = "F-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. Factura:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.processinvoice);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 269);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entrada de Factura";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(341, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // processinvoice
            // 
            this.processinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processinvoice.Location = new System.Drawing.Point(249, 39);
            this.processinvoice.Name = "processinvoice";
            this.processinvoice.Size = new System.Drawing.Size(75, 23);
            this.processinvoice.TabIndex = 6;
            this.processinvoice.Text = "button1";
            this.processinvoice.UseVisualStyleBackColor = true;
            this.processinvoice.Click += new System.EventHandler(this.processinvoice_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.idonsys);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 49);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // idonsys
            // 
            this.idonsys.Enabled = false;
            this.idonsys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idonsys.Location = new System.Drawing.Point(129, 19);
            this.idonsys.Name = "idonsys";
            this.idonsys.Size = new System.Drawing.Size(65, 20);
            this.idonsys.TabIndex = 4;
            this.idonsys.TextChanged += new System.EventHandler(this.idonsys_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID en SysPandemic:";
            // 
            // enterinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 287);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "enterinvoice";
            this.Text = "Entrada de Factura";
            this.Load += new System.EventHandler(this.enterinvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox nameprovider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchprovider;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox idprovider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox reasonbill;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox nobill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox idonsys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button processinvoice;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker datebill;
        public System.Windows.Forms.ComboBox paymeth;
    }
}