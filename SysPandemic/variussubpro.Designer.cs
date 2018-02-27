namespace SysPandemic
{
    partial class variussubpro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(variussubpro));
            this.vsp_insurance_txt = new System.Windows.Forms.TextBox();
            this.vsp_activity_txt = new System.Windows.Forms.TextBox();
            this.vsp_tariff_txt = new System.Windows.Forms.TextBox();
            this.vsp_codeinsu_txt = new System.Windows.Forms.TextBox();
            this.vsp_idprocedure_txt = new System.Windows.Forms.TextBox();
            this.vsp_difference_txt = new System.Windows.Forms.TextBox();
            this.vsp_tooth_txt = new System.Windows.Forms.TextBox();
            this.vsp_coverage_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addsubpro_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsp_insurance_txt
            // 
            this.vsp_insurance_txt.Enabled = false;
            this.vsp_insurance_txt.Location = new System.Drawing.Point(186, 43);
            this.vsp_insurance_txt.Name = "vsp_insurance_txt";
            this.vsp_insurance_txt.ReadOnly = true;
            this.vsp_insurance_txt.Size = new System.Drawing.Size(181, 20);
            this.vsp_insurance_txt.TabIndex = 0;
            // 
            // vsp_activity_txt
            // 
            this.vsp_activity_txt.Enabled = false;
            this.vsp_activity_txt.Location = new System.Drawing.Point(76, 69);
            this.vsp_activity_txt.Name = "vsp_activity_txt";
            this.vsp_activity_txt.ReadOnly = true;
            this.vsp_activity_txt.Size = new System.Drawing.Size(291, 20);
            this.vsp_activity_txt.TabIndex = 1;
            this.vsp_activity_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // vsp_tariff_txt
            // 
            this.vsp_tariff_txt.Location = new System.Drawing.Point(53, 121);
            this.vsp_tariff_txt.Name = "vsp_tariff_txt";
            this.vsp_tariff_txt.Size = new System.Drawing.Size(100, 20);
            this.vsp_tariff_txt.TabIndex = 2;
            this.vsp_tariff_txt.TextChanged += new System.EventHandler(this.vsp_tariff_txt_TextChanged);
            // 
            // vsp_codeinsu_txt
            // 
            this.vsp_codeinsu_txt.Enabled = false;
            this.vsp_codeinsu_txt.Location = new System.Drawing.Point(63, 43);
            this.vsp_codeinsu_txt.Name = "vsp_codeinsu_txt";
            this.vsp_codeinsu_txt.ReadOnly = true;
            this.vsp_codeinsu_txt.Size = new System.Drawing.Size(60, 20);
            this.vsp_codeinsu_txt.TabIndex = 3;
            // 
            // vsp_idprocedure_txt
            // 
            this.vsp_idprocedure_txt.Enabled = false;
            this.vsp_idprocedure_txt.Location = new System.Drawing.Point(104, 17);
            this.vsp_idprocedure_txt.Name = "vsp_idprocedure_txt";
            this.vsp_idprocedure_txt.ReadOnly = true;
            this.vsp_idprocedure_txt.Size = new System.Drawing.Size(64, 20);
            this.vsp_idprocedure_txt.TabIndex = 4;
            this.vsp_idprocedure_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // vsp_difference_txt
            // 
            this.vsp_difference_txt.Enabled = false;
            this.vsp_difference_txt.Location = new System.Drawing.Point(158, 147);
            this.vsp_difference_txt.Name = "vsp_difference_txt";
            this.vsp_difference_txt.ReadOnly = true;
            this.vsp_difference_txt.Size = new System.Drawing.Size(89, 20);
            this.vsp_difference_txt.TabIndex = 5;
            // 
            // vsp_tooth_txt
            // 
            this.vsp_tooth_txt.Location = new System.Drawing.Point(53, 95);
            this.vsp_tooth_txt.Name = "vsp_tooth_txt";
            this.vsp_tooth_txt.Size = new System.Drawing.Size(85, 20);
            this.vsp_tooth_txt.TabIndex = 6;
            // 
            // vsp_coverage_txt
            // 
            this.vsp_coverage_txt.Enabled = false;
            this.vsp_coverage_txt.Location = new System.Drawing.Point(248, 121);
            this.vsp_coverage_txt.Name = "vsp_coverage_txt";
            this.vsp_coverage_txt.ReadOnly = true;
            this.vsp_coverage_txt.Size = new System.Drawing.Size(90, 20);
            this.vsp_coverage_txt.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.vsp_difference_txt);
            this.groupBox2.Controls.Add(this.vsp_activity_txt);
            this.groupBox2.Controls.Add(this.vsp_insurance_txt);
            this.groupBox2.Controls.Add(this.vsp_coverage_txt);
            this.groupBox2.Controls.Add(this.vsp_tariff_txt);
            this.groupBox2.Controls.Add(this.vsp_tooth_txt);
            this.groupBox2.Controls.Add(this.vsp_codeinsu_txt);
            this.groupBox2.Controls.Add(this.vsp_idprocedure_txt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 176);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar antes de agregar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Diferencia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cobertura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tarifa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seguro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Diente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Actividad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Procedimiento:";
            // 
            // addsubpro_btn
            // 
            this.addsubpro_btn.BackColor = System.Drawing.Color.Navy;
            this.addsubpro_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsubpro_btn.ForeColor = System.Drawing.Color.Transparent;
            this.addsubpro_btn.Location = new System.Drawing.Point(12, 194);
            this.addsubpro_btn.Name = "addsubpro_btn";
            this.addsubpro_btn.Size = new System.Drawing.Size(373, 23);
            this.addsubpro_btn.TabIndex = 10;
            this.addsubpro_btn.Text = "Agregar SubProcedimiento";
            this.addsubpro_btn.UseVisualStyleBackColor = false;
            this.addsubpro_btn.Click += new System.EventHandler(this.addsubpro_btn_Click);
            // 
            // variussubpro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(397, 223);
            this.Controls.Add(this.addsubpro_btn);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "variussubpro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Varios SubProcedimientos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Activated += new System.EventHandler(this.variussubpro_Activated);
            this.Load += new System.EventHandler(this.variussubpro_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addsubpro_btn;
        public System.Windows.Forms.TextBox vsp_insurance_txt;
        public System.Windows.Forms.TextBox vsp_activity_txt;
        public System.Windows.Forms.TextBox vsp_tariff_txt;
        public System.Windows.Forms.TextBox vsp_codeinsu_txt;
        public System.Windows.Forms.TextBox vsp_idprocedure_txt;
        public System.Windows.Forms.TextBox vsp_difference_txt;
        public System.Windows.Forms.TextBox vsp_tooth_txt;
        public System.Windows.Forms.TextBox vsp_coverage_txt;
    }
}