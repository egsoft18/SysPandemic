namespace SysPandemic
{
    partial class addpwi
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
            this.idprocess_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.process_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceprocess_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updatepwi_btn = new System.Windows.Forms.Button();
            this.deletepwi_btn = new System.Windows.Forms.Button();
            this.savepwi_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceprocess_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.process_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idprocess_txt);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso sin seguro";
            // 
            // idprocess_txt
            // 
            this.idprocess_txt.Enabled = false;
            this.idprocess_txt.Location = new System.Drawing.Point(50, 28);
            this.idprocess_txt.Name = "idprocess_txt";
            this.idprocess_txt.Size = new System.Drawing.Size(83, 20);
            this.idprocess_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // process_txt
            // 
            this.process_txt.Location = new System.Drawing.Point(194, 28);
            this.process_txt.Name = "process_txt";
            this.process_txt.Size = new System.Drawing.Size(397, 20);
            this.process_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proceso:";
            // 
            // priceprocess_txt
            // 
            this.priceprocess_txt.Location = new System.Drawing.Point(508, 54);
            this.priceprocess_txt.Name = "priceprocess_txt";
            this.priceprocess_txt.Size = new System.Drawing.Size(83, 20);
            this.priceprocess_txt.TabIndex = 4;
            this.priceprocess_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RD$";
            // 
            // updatepwi_btn
            // 
            this.updatepwi_btn.Location = new System.Drawing.Point(70, 111);
            this.updatepwi_btn.Name = "updatepwi_btn";
            this.updatepwi_btn.Size = new System.Drawing.Size(75, 23);
            this.updatepwi_btn.TabIndex = 1;
            this.updatepwi_btn.Text = "Actualizar";
            this.updatepwi_btn.UseVisualStyleBackColor = true;
            this.updatepwi_btn.Click += new System.EventHandler(this.updatepwi_btn_Click);
            // 
            // deletepwi_btn
            // 
            this.deletepwi_btn.Location = new System.Drawing.Point(155, 111);
            this.deletepwi_btn.Name = "deletepwi_btn";
            this.deletepwi_btn.Size = new System.Drawing.Size(75, 23);
            this.deletepwi_btn.TabIndex = 2;
            this.deletepwi_btn.Text = "Borrar";
            this.deletepwi_btn.UseVisualStyleBackColor = true;
            // 
            // savepwi_btn
            // 
            this.savepwi_btn.Location = new System.Drawing.Point(335, 111);
            this.savepwi_btn.Name = "savepwi_btn";
            this.savepwi_btn.Size = new System.Drawing.Size(75, 23);
            this.savepwi_btn.TabIndex = 3;
            this.savepwi_btn.Text = "Guardar";
            this.savepwi_btn.UseVisualStyleBackColor = true;
            this.savepwi_btn.Click += new System.EventHandler(this.savepwi_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(442, 111);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "Cancelar";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // addpwi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 150);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.savepwi_btn);
            this.Controls.Add(this.deletepwi_btn);
            this.Controls.Add(this.updatepwi_btn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "addpwi";
            this.Text = "Proceso sin Seguro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox process_txt;
        public System.Windows.Forms.TextBox idprocess_txt;
        public System.Windows.Forms.TextBox priceprocess_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button updatepwi_btn;
        public System.Windows.Forms.Button deletepwi_btn;
        public System.Windows.Forms.Button savepwi_btn;
        public System.Windows.Forms.Button close_btn;
    }
}