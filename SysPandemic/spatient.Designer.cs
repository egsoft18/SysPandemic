namespace SysPandemic
{
    partial class spatient
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
            this.sidperson_rbtn = new System.Windows.Forms.RadioButton();
            this.sname_rbtn = new System.Windows.Forms.RadioButton();
            this.sid_rbtn = new System.Windows.Forms.RadioButton();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(464, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sidperson_rbtn
            // 
            this.sidperson_rbtn.AutoSize = true;
            this.sidperson_rbtn.Location = new System.Drawing.Point(245, 12);
            this.sidperson_rbtn.Name = "sidperson_rbtn";
            this.sidperson_rbtn.Size = new System.Drawing.Size(58, 17);
            this.sidperson_rbtn.TabIndex = 1;
            this.sidperson_rbtn.TabStop = true;
            this.sidperson_rbtn.Text = "Cedula";
            this.sidperson_rbtn.UseVisualStyleBackColor = true;
            // 
            // sname_rbtn
            // 
            this.sname_rbtn.AutoSize = true;
            this.sname_rbtn.Location = new System.Drawing.Point(130, 12);
            this.sname_rbtn.Name = "sname_rbtn";
            this.sname_rbtn.Size = new System.Drawing.Size(62, 17);
            this.sname_rbtn.TabIndex = 2;
            this.sname_rbtn.TabStop = true;
            this.sname_rbtn.Text = "Nombre";
            this.sname_rbtn.UseVisualStyleBackColor = true;
            // 
            // sid_rbtn
            // 
            this.sid_rbtn.AutoSize = true;
            this.sid_rbtn.Location = new System.Drawing.Point(12, 12);
            this.sid_rbtn.Name = "sid_rbtn";
            this.sid_rbtn.Size = new System.Drawing.Size(36, 17);
            this.sid_rbtn.TabIndex = 3;
            this.sid_rbtn.TabStop = true;
            this.sid_rbtn.Text = "ID";
            this.sid_rbtn.UseVisualStyleBackColor = true;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(12, 35);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(318, 20);
            this.search_txt.TabIndex = 4;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(369, 33);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 5;
            this.search_btn.Text = "Buscar";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // spatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 312);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.sid_rbtn);
            this.Controls.Add(this.sname_rbtn);
            this.Controls.Add(this.sidperson_rbtn);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "spatient";
            this.Text = "Buscar paciente";
            this.Load += new System.EventHandler(this.Searchpatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton sidperson_rbtn;
        private System.Windows.Forms.RadioButton sname_rbtn;
        private System.Windows.Forms.RadioButton sid_rbtn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button search_btn;
    }
}