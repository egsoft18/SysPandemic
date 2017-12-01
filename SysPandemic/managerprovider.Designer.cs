namespace SysPandemic
{
    partial class managerprovider
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
            this.idprovider_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameprovider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressprovider = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telprovider = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailprovider = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.namecontactp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telcontactp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.positioncontactp = new System.Windows.Forms.TextBox();
            this.proccess_btn = new System.Windows.Forms.Button();
            this.deleteprovider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idprovider_txt
            // 
            this.idprovider_txt.Enabled = false;
            this.idprovider_txt.Location = new System.Drawing.Point(47, 28);
            this.idprovider_txt.Name = "idprovider_txt";
            this.idprovider_txt.Size = new System.Drawing.Size(54, 20);
            this.idprovider_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailprovider);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.telprovider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addressprovider);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameprovider);
            this.groupBox1.Controls.Add(this.idprovider_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales:";
            // 
            // nameprovider
            // 
            this.nameprovider.Location = new System.Drawing.Point(148, 54);
            this.nameprovider.Name = "nameprovider";
            this.nameprovider.Size = new System.Drawing.Size(264, 20);
            this.nameprovider.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion:";
            // 
            // addressprovider
            // 
            this.addressprovider.Location = new System.Drawing.Point(77, 80);
            this.addressprovider.Name = "addressprovider";
            this.addressprovider.Size = new System.Drawing.Size(335, 20);
            this.addressprovider.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tel.:";
            // 
            // telprovider
            // 
            this.telprovider.Location = new System.Drawing.Point(45, 106);
            this.telprovider.Name = "telprovider";
            this.telprovider.Size = new System.Drawing.Size(141, 20);
            this.telprovider.TabIndex = 6;
            this.telprovider.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail:";
            // 
            // emailprovider
            // 
            this.emailprovider.Location = new System.Drawing.Point(239, 106);
            this.emailprovider.Name = "emailprovider";
            this.emailprovider.Size = new System.Drawing.Size(173, 20);
            this.emailprovider.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.positioncontactp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.telcontactp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.namecontactp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre del contacto:";
            // 
            // namecontactp
            // 
            this.namecontactp.Location = new System.Drawing.Point(143, 19);
            this.namecontactp.Name = "namecontactp";
            this.namecontactp.Size = new System.Drawing.Size(269, 20);
            this.namecontactp.TabIndex = 10;
            this.namecontactp.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono del contacto:";
            // 
            // telcontactp
            // 
            this.telcontactp.Location = new System.Drawing.Point(150, 75);
            this.telcontactp.Name = "telcontactp";
            this.telcontactp.Size = new System.Drawing.Size(262, 20);
            this.telcontactp.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Posicion del contacto:";
            // 
            // positioncontactp
            // 
            this.positioncontactp.Location = new System.Drawing.Point(148, 45);
            this.positioncontactp.Name = "positioncontactp";
            this.positioncontactp.Size = new System.Drawing.Size(262, 20);
            this.positioncontactp.TabIndex = 14;
            // 
            // proccess_btn
            // 
            this.proccess_btn.Location = new System.Drawing.Point(162, 280);
            this.proccess_btn.Name = "proccess_btn";
            this.proccess_btn.Size = new System.Drawing.Size(168, 23);
            this.proccess_btn.TabIndex = 4;
            this.proccess_btn.Text = "button1";
            this.proccess_btn.UseVisualStyleBackColor = true;
            this.proccess_btn.Click += new System.EventHandler(this.proccess_btn_Click);
            // 
            // deleteprovider
            // 
            this.deleteprovider.Location = new System.Drawing.Point(355, 280);
            this.deleteprovider.Name = "deleteprovider";
            this.deleteprovider.Size = new System.Drawing.Size(75, 23);
            this.deleteprovider.TabIndex = 5;
            this.deleteprovider.Text = "Borrar";
            this.deleteprovider.UseVisualStyleBackColor = true;
            // 
            // managerprovider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(442, 315);
            this.Controls.Add(this.deleteprovider);
            this.Controls.Add(this.proccess_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "managerprovider";
            this.Text = "Manejador de proveedor";
            this.Load += new System.EventHandler(this.managerprovider_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telprovider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressprovider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameprovider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailprovider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox namecontactp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox positioncontactp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telcontactp;
        private System.Windows.Forms.Button proccess_btn;
        private System.Windows.Forms.Button deleteprovider;
        public System.Windows.Forms.TextBox idprovider_txt;
    }
}