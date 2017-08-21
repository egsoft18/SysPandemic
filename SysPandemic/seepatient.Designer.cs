namespace SysPandemic
{
    partial class searchpatient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sid_rbtn = new System.Windows.Forms.RadioButton();
            this.sname_rbtn = new System.Windows.Forms.RadioButton();
            this.sidperson_rbtn = new System.Windows.Forms.RadioButton();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.addpatient_btn = new System.Windows.Forms.Button();
            this.refreshpatient_btn = new System.Windows.Forms.Button();
            this.printpatientlist_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(13, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sid_rbtn
            // 
            this.sid_rbtn.AutoSize = true;
            this.sid_rbtn.Location = new System.Drawing.Point(102, 12);
            this.sid_rbtn.Name = "sid_rbtn";
            this.sid_rbtn.Size = new System.Drawing.Size(36, 17);
            this.sid_rbtn.TabIndex = 1;
            this.sid_rbtn.TabStop = true;
            this.sid_rbtn.Text = "ID";
            this.sid_rbtn.UseVisualStyleBackColor = true;
            this.sid_rbtn.CheckedChanged += new System.EventHandler(this.sid_rbtn_CheckedChanged);
            // 
            // sname_rbtn
            // 
            this.sname_rbtn.AutoSize = true;
            this.sname_rbtn.Location = new System.Drawing.Point(153, 12);
            this.sname_rbtn.Name = "sname_rbtn";
            this.sname_rbtn.Size = new System.Drawing.Size(62, 17);
            this.sname_rbtn.TabIndex = 2;
            this.sname_rbtn.TabStop = true;
            this.sname_rbtn.Text = "Nombre";
            this.sname_rbtn.UseVisualStyleBackColor = true;
            // 
            // sidperson_rbtn
            // 
            this.sidperson_rbtn.AutoSize = true;
            this.sidperson_rbtn.Location = new System.Drawing.Point(232, 12);
            this.sidperson_rbtn.Name = "sidperson_rbtn";
            this.sidperson_rbtn.Size = new System.Drawing.Size(58, 17);
            this.sidperson_rbtn.TabIndex = 3;
            this.sidperson_rbtn.TabStop = true;
            this.sidperson_rbtn.Text = "Cédula";
            this.sidperson_rbtn.UseVisualStyleBackColor = true;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(296, 11);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(556, 20);
            this.search_txt.TabIndex = 4;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(858, 9);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 5;
            this.search_btn.Text = "Buscar";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // addpatient_btn
            // 
            this.addpatient_btn.Location = new System.Drawing.Point(939, 9);
            this.addpatient_btn.Name = "addpatient_btn";
            this.addpatient_btn.Size = new System.Drawing.Size(75, 23);
            this.addpatient_btn.TabIndex = 6;
            this.addpatient_btn.Text = "Agregar";
            this.addpatient_btn.UseVisualStyleBackColor = true;
            this.addpatient_btn.Click += new System.EventHandler(this.addpatient_btn_Click);
            // 
            // refreshpatient_btn
            // 
            this.refreshpatient_btn.Location = new System.Drawing.Point(1020, 9);
            this.refreshpatient_btn.Name = "refreshpatient_btn";
            this.refreshpatient_btn.Size = new System.Drawing.Size(75, 23);
            this.refreshpatient_btn.TabIndex = 7;
            this.refreshpatient_btn.Text = "Refrescar";
            this.refreshpatient_btn.UseVisualStyleBackColor = true;
            this.refreshpatient_btn.Click += new System.EventHandler(this.refreshpatient_btn_Click);
            // 
            // printpatientlist_btn
            // 
            this.printpatientlist_btn.Location = new System.Drawing.Point(1101, 9);
            this.printpatientlist_btn.Name = "printpatientlist_btn";
            this.printpatientlist_btn.Size = new System.Drawing.Size(75, 23);
            this.printpatientlist_btn.TabIndex = 8;
            this.printpatientlist_btn.Text = "Imprimir";
            this.printpatientlist_btn.UseVisualStyleBackColor = true;
            this.printpatientlist_btn.Click += new System.EventHandler(this.printpatientlist_btn_Click);
            // 
            // searchpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1205, 607);
            this.Controls.Add(this.printpatientlist_btn);
            this.Controls.Add(this.refreshpatient_btn);
            this.Controls.Add(this.addpatient_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.sidperson_rbtn);
            this.Controls.Add(this.sname_rbtn);
            this.Controls.Add(this.sid_rbtn);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "searchpatient";
            this.Text = "Administrar Pacientes";
            this.Load += new System.EventHandler(this.seepatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton sid_rbtn;
        private System.Windows.Forms.RadioButton sname_rbtn;
        private System.Windows.Forms.RadioButton sidperson_rbtn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button addpatient_btn;
        private System.Windows.Forms.Button refreshpatient_btn;
        private System.Windows.Forms.Button printpatientlist_btn;
    }
}