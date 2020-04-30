namespace SysPandemic
{
    partial class seepwi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seepwi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchprocess_txt = new System.Windows.Forms.TextBox();
            this.addprocess_btn = new System.Windows.Forms.Button();
            this.printprocess_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(555, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // searchprocess_txt
            // 
            this.searchprocess_txt.Location = new System.Drawing.Point(12, 24);
            this.searchprocess_txt.Name = "searchprocess_txt";
            this.searchprocess_txt.Size = new System.Drawing.Size(312, 20);
            this.searchprocess_txt.TabIndex = 1;
            this.searchprocess_txt.TextChanged += new System.EventHandler(this.searchprocess_txt_TextChanged);
            // 
            // addprocess_btn
            // 
            this.addprocess_btn.Location = new System.Drawing.Point(411, 22);
            this.addprocess_btn.Name = "addprocess_btn";
            this.addprocess_btn.Size = new System.Drawing.Size(75, 23);
            this.addprocess_btn.TabIndex = 2;
            this.addprocess_btn.Text = "Agregar";
            this.addprocess_btn.UseVisualStyleBackColor = true;
            this.addprocess_btn.Click += new System.EventHandler(this.addprocess_btn_Click);
            // 
            // printprocess_btn
            // 
            this.printprocess_btn.Location = new System.Drawing.Point(492, 22);
            this.printprocess_btn.Name = "printprocess_btn";
            this.printprocess_btn.Size = new System.Drawing.Size(75, 23);
            this.printprocess_btn.TabIndex = 3;
            this.printprocess_btn.Text = "Imprimir";
            this.printprocess_btn.UseVisualStyleBackColor = true;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(330, 22);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 4;
            this.refresh_btn.Text = "Refrescar";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // seepwi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(579, 457);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.printprocess_btn);
            this.Controls.Add(this.addprocess_btn);
            this.Controls.Add(this.searchprocess_txt);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "seepwi";
            this.Text = "Procedimientos sin seguro";
            this.Activated += new System.EventHandler(this.seepwi_Activated);
            this.Load += new System.EventHandler(this.seepwi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchprocess_txt;
        private System.Windows.Forms.Button addprocess_btn;
        private System.Windows.Forms.Button printprocess_btn;
        private System.Windows.Forms.Button refresh_btn;
    }
}