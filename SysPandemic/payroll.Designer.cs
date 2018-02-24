namespace SysPandemic
{
    partial class payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payroll));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jakdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kjdkajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condition_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payrollsearch_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(520, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // jakdToolStripMenuItem
            // 
            this.jakdToolStripMenuItem.Name = "jakdToolStripMenuItem";
            this.jakdToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.jakdToolStripMenuItem.Text = "jakd";
            // 
            // kjdkajToolStripMenuItem
            // 
            this.kjdkajToolStripMenuItem.Name = "kjdkajToolStripMenuItem";
            this.kjdkajToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.kjdkajToolStripMenuItem.Text = "kjdkaj";
            // 
            // condition_txt
            // 
            this.condition_txt.Location = new System.Drawing.Point(438, 245);
            this.condition_txt.Name = "condition_txt";
            this.condition_txt.ReadOnly = true;
            this.condition_txt.Size = new System.Drawing.Size(100, 20);
            this.condition_txt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.payrollsearch_txt);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Nomina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por nombre:";
            // 
            // payrollsearch_txt
            // 
            this.payrollsearch_txt.Location = new System.Drawing.Point(199, 19);
            this.payrollsearch_txt.Name = "payrollsearch_txt";
            this.payrollsearch_txt.Size = new System.Drawing.Size(327, 20);
            this.payrollsearch_txt.TabIndex = 1;
            this.payrollsearch_txt.TextChanged += new System.EventHandler(this.payrollsearch_txt_TextChanged);
            // 
            // payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 239);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.condition_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "payroll";
            this.Text = "Vista de Nomina";
            this.Activated += new System.EventHandler(this.payroll_Activated);
            this.Load += new System.EventHandler(this.payroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.ToolStripMenuItem jakdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kjdkajToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox payrollsearch_txt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox condition_txt;
    }
}