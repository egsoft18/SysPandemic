namespace SysPandemic
{
    partial class suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliers));
            this.providers_dgv = new System.Windows.Forms.DataGridView();
            this.searchprovider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.providers_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // providers_dgv
            // 
            this.providers_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.providers_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.providers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providers_dgv.Location = new System.Drawing.Point(12, 67);
            this.providers_dgv.Name = "providers_dgv";
            this.providers_dgv.ReadOnly = true;
            this.providers_dgv.Size = new System.Drawing.Size(669, 290);
            this.providers_dgv.TabIndex = 0;
            this.providers_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.providers_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // searchprovider
            // 
            this.searchprovider.Location = new System.Drawing.Point(17, 41);
            this.searchprovider.Name = "searchprovider";
            this.searchprovider.Size = new System.Drawing.Size(466, 20);
            this.searchprovider.TabIndex = 1;
            this.searchprovider.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de Suplidores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshp
            // 
            this.refreshp.Location = new System.Drawing.Point(525, 38);
            this.refreshp.Name = "refreshp";
            this.refreshp.Size = new System.Drawing.Size(75, 23);
            this.refreshp.TabIndex = 4;
            this.refreshp.Text = "Refrescar";
            this.refreshp.UseVisualStyleBackColor = true;
            this.refreshp.Click += new System.EventHandler(this.refreshp_Click);
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 369);
            this.Controls.Add(this.refreshp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchprovider);
            this.Controls.Add(this.providers_dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "suppliers";
            this.Text = "Suplidores";
            this.Activated += new System.EventHandler(this.suppliers_Activated);
            this.Load += new System.EventHandler(this.suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providers_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchprovider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshp;
        public System.Windows.Forms.DataGridView providers_dgv;
    }
}