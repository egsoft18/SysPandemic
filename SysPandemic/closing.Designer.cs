namespace SysPandemic
{
    partial class closing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(closing));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transout = new System.Windows.Forms.RadioButton();
            this.transentry = new System.Windows.Forms.RadioButton();
            this.transall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.rankdate = new System.Windows.Forms.RadioButton();
            this.rankall = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.paytype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transout);
            this.groupBox1.Controls.Add(this.transentry);
            this.groupBox1.Controls.Add(this.transall);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Transacción";
            // 
            // transout
            // 
            this.transout.AutoSize = true;
            this.transout.Location = new System.Drawing.Point(136, 32);
            this.transout.Name = "transout";
            this.transout.Size = new System.Drawing.Size(54, 17);
            this.transout.TabIndex = 2;
            this.transout.TabStop = true;
            this.transout.Text = "Salida";
            this.transout.UseVisualStyleBackColor = true;
            // 
            // transentry
            // 
            this.transentry.AutoSize = true;
            this.transentry.Location = new System.Drawing.Point(68, 32);
            this.transentry.Name = "transentry";
            this.transentry.Size = new System.Drawing.Size(62, 17);
            this.transentry.TabIndex = 1;
            this.transentry.TabStop = true;
            this.transentry.Text = "Entrada";
            this.transentry.UseVisualStyleBackColor = true;
            // 
            // transall
            // 
            this.transall.AutoSize = true;
            this.transall.Location = new System.Drawing.Point(7, 32);
            this.transall.Name = "transall";
            this.transall.Size = new System.Drawing.Size(55, 17);
            this.transall.TabIndex = 0;
            this.transall.TabStop = true;
            this.transall.Text = "Todas";
            this.transall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateend);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.datestart);
            this.groupBox2.Controls.Add(this.rankdate);
            this.groupBox2.Controls.Add(this.rankall);
            this.groupBox2.Location = new System.Drawing.Point(13, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango";
            // 
            // dateend
            // 
            this.dateend.CustomFormat = "yyyy-MM-dd";
            this.dateend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateend.Location = new System.Drawing.Point(174, 55);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(100, 20);
            this.dateend.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a";
            // 
            // datestart
            // 
            this.datestart.CustomFormat = "yyyy-MM-dd";
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datestart.Location = new System.Drawing.Point(61, 55);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(88, 20);
            this.datestart.TabIndex = 2;
            // 
            // rankdate
            // 
            this.rankdate.AutoSize = true;
            this.rankdate.Location = new System.Drawing.Point(111, 32);
            this.rankdate.Name = "rankdate";
            this.rankdate.Size = new System.Drawing.Size(102, 17);
            this.rankdate.TabIndex = 1;
            this.rankdate.TabStop = true;
            this.rankdate.Text = "Rango de fecha";
            this.rankdate.UseVisualStyleBackColor = true;
            this.rankdate.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rankall
            // 
            this.rankall.AutoSize = true;
            this.rankall.Location = new System.Drawing.Point(7, 32);
            this.rankall.Name = "rankall";
            this.rankall.Size = new System.Drawing.Size(55, 17);
            this.rankall.TabIndex = 0;
            this.rankall.TabStop = true;
            this.rankall.Text = "Todas";
            this.rankall.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.paytype);
            this.groupBox3.Location = new System.Drawing.Point(13, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de pago";
            // 
            // paytype
            // 
            this.paytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paytype.FormattingEnabled = true;
            this.paytype.Items.AddRange(new object[] {
            "Todos",
            "Efectivo",
            "Tarjeta",
            "Banco",
            "Cheque"});
            this.paytype.Location = new System.Drawing.Point(22, 20);
            this.paytype.Name = "paytype";
            this.paytype.Size = new System.Drawing.Size(260, 21);
            this.paytype.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ver Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(335, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "closing";
            this.Text = "Cierre";
            this.Load += new System.EventHandler(this.closing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton transout;
        private System.Windows.Forms.RadioButton transentry;
        private System.Windows.Forms.RadioButton transall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rankall;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.RadioButton rankdate;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox paytype;
        private System.Windows.Forms.Button button1;
    }
}