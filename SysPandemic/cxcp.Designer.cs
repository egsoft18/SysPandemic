namespace SysPandemic
{
    partial class cxcp
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
            this.cp_rbtn = new System.Windows.Forms.RadioButton();
            this.cxc_rbtn = new System.Windows.Forms.RadioButton();
            this.allcxc_rbtn = new System.Windows.Forms.RadioButton();
            this.rankdate_rbtn = new System.Windows.Forms.RadioButton();
            this.startrank_dtp = new System.Windows.Forms.DateTimePicker();
            this.endrank_dtp = new System.Windows.Forms.DateTimePicker();
            this.seecxc_rbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cp_rbtn);
            this.groupBox1.Controls.Add(this.cxc_rbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 37);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cp_rbtn
            // 
            this.cp_rbtn.AutoSize = true;
            this.cp_rbtn.Location = new System.Drawing.Point(152, 14);
            this.cp_rbtn.Name = "cp_rbtn";
            this.cp_rbtn.Size = new System.Drawing.Size(108, 17);
            this.cp_rbtn.TabIndex = 1;
            this.cp_rbtn.TabStop = true;
            this.cp_rbtn.Text = "Cuentas pagadas";
            this.cp_rbtn.UseVisualStyleBackColor = true;
            // 
            // cxc_rbtn
            // 
            this.cxc_rbtn.AutoSize = true;
            this.cxc_rbtn.Location = new System.Drawing.Point(7, 14);
            this.cxc_rbtn.Name = "cxc_rbtn";
            this.cxc_rbtn.Size = new System.Drawing.Size(115, 17);
            this.cxc_rbtn.TabIndex = 0;
            this.cxc_rbtn.TabStop = true;
            this.cxc_rbtn.Text = "Cuentas por cobrar";
            this.cxc_rbtn.UseVisualStyleBackColor = true;
            // 
            // allcxc_rbtn
            // 
            this.allcxc_rbtn.AutoSize = true;
            this.allcxc_rbtn.Location = new System.Drawing.Point(64, 85);
            this.allcxc_rbtn.Name = "allcxc_rbtn";
            this.allcxc_rbtn.Size = new System.Drawing.Size(55, 17);
            this.allcxc_rbtn.TabIndex = 2;
            this.allcxc_rbtn.TabStop = true;
            this.allcxc_rbtn.Text = "Todas";
            this.allcxc_rbtn.UseVisualStyleBackColor = true;
            // 
            // rankdate_rbtn
            // 
            this.rankdate_rbtn.AutoSize = true;
            this.rankdate_rbtn.Location = new System.Drawing.Point(131, 85);
            this.rankdate_rbtn.Name = "rankdate_rbtn";
            this.rankdate_rbtn.Size = new System.Drawing.Size(102, 17);
            this.rankdate_rbtn.TabIndex = 3;
            this.rankdate_rbtn.TabStop = true;
            this.rankdate_rbtn.Text = "Rango de fecha";
            this.rankdate_rbtn.UseVisualStyleBackColor = true;
            // 
            // startrank_dtp
            // 
            this.startrank_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startrank_dtp.Location = new System.Drawing.Point(19, 108);
            this.startrank_dtp.Name = "startrank_dtp";
            this.startrank_dtp.Size = new System.Drawing.Size(87, 20);
            this.startrank_dtp.TabIndex = 4;
            // 
            // endrank_dtp
            // 
            this.endrank_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endrank_dtp.Location = new System.Drawing.Point(185, 108);
            this.endrank_dtp.Name = "endrank_dtp";
            this.endrank_dtp.Size = new System.Drawing.Size(87, 20);
            this.endrank_dtp.TabIndex = 5;
            // 
            // seecxc_rbtn
            // 
            this.seecxc_rbtn.Location = new System.Drawing.Point(104, 144);
            this.seecxc_rbtn.Name = "seecxc_rbtn";
            this.seecxc_rbtn.Size = new System.Drawing.Size(75, 23);
            this.seecxc_rbtn.TabIndex = 6;
            this.seecxc_rbtn.Text = "Ver reporte";
            this.seecxc_rbtn.UseVisualStyleBackColor = true;
            this.seecxc_rbtn.Click += new System.EventHandler(this.seecxc_rbtn_Click);
            // 
            // cxcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.seecxc_rbtn);
            this.Controls.Add(this.endrank_dtp);
            this.Controls.Add(this.startrank_dtp);
            this.Controls.Add(this.rankdate_rbtn);
            this.Controls.Add(this.allcxc_rbtn);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "cxcp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por cobrar/Cuentas pagadas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cp_rbtn;
        private System.Windows.Forms.RadioButton rankdate_rbtn;
        private System.Windows.Forms.DateTimePicker startrank_dtp;
        private System.Windows.Forms.DateTimePicker endrank_dtp;
        private System.Windows.Forms.Button seecxc_rbtn;
        public System.Windows.Forms.RadioButton cxc_rbtn;
        public System.Windows.Forms.RadioButton allcxc_rbtn;
    }
}