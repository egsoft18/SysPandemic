namespace SysPandemic
{
    partial class seeinvoice
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
            this.provider_rbtn = new System.Windows.Forms.RadioButton();
            this.reason_rbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbill = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // provider_rbtn
            // 
            this.provider_rbtn.AutoSize = true;
            this.provider_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provider_rbtn.Location = new System.Drawing.Point(196, 25);
            this.provider_rbtn.Name = "provider_rbtn";
            this.provider_rbtn.Size = new System.Drawing.Size(81, 19);
            this.provider_rbtn.TabIndex = 1;
            this.provider_rbtn.TabStop = true;
            this.provider_rbtn.Text = "Proveedor";
            this.provider_rbtn.UseVisualStyleBackColor = true;
            // 
            // reason_rbtn
            // 
            this.reason_rbtn.AutoSize = true;
            this.reason_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason_rbtn.Location = new System.Drawing.Point(283, 25);
            this.reason_rbtn.Name = "reason_rbtn";
            this.reason_rbtn.Size = new System.Drawing.Size(93, 19);
            this.reason_rbtn.TabIndex = 2;
            this.reason_rbtn.TabStop = true;
            this.reason_rbtn.Text = "Razon Pago";
            this.reason_rbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.searchbill);
            this.groupBox1.Controls.Add(this.reason_rbtn);
            this.groupBox1.Controls.Add(this.provider_rbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 336);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver Facturas en el Sistema";
            // 
            // searchbill
            // 
            this.searchbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbill.Location = new System.Drawing.Point(379, 25);
            this.searchbill.Name = "searchbill";
            this.searchbill.Size = new System.Drawing.Size(517, 20);
            this.searchbill.TabIndex = 3;
            this.searchbill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(902, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(970, 279);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // seeinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1007, 356);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "seeinvoice";
            this.Text = "seeinvoice";
            this.Load += new System.EventHandler(this.seeinvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton provider_rbtn;
        private System.Windows.Forms.RadioButton reason_rbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchbill;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}