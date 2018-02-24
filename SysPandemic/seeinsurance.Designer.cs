namespace SysPandemic
{
    partial class seeinsurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seeinsurance));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.searchinsurance_btn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(871, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(287, 8);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(405, 20);
            this.search_txt.TabIndex = 1;
            this.search_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchinsurance_btn
            // 
            this.searchinsurance_btn.Location = new System.Drawing.Point(698, 6);
            this.searchinsurance_btn.Name = "searchinsurance_btn";
            this.searchinsurance_btn.Size = new System.Drawing.Size(75, 23);
            this.searchinsurance_btn.TabIndex = 2;
            this.searchinsurance_btn.Text = "Buscar";
            this.searchinsurance_btn.UseVisualStyleBackColor = true;
            this.searchinsurance_btn.Click += new System.EventHandler(this.searchinsurance_btn_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(779, 6);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refrescar";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // seeinsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 261);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.searchinsurance_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "seeinsurance";
            this.Text = "seeinsurance";
            this.Activated += new System.EventHandler(this.seeinsurance_Activated);
            this.Load += new System.EventHandler(this.seeinsurance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button searchinsurance_btn;
        private System.Windows.Forms.Button refresh;
    }
}