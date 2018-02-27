namespace SysPandemic
{
    partial class viewnotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewnotes));
            this.vn_idpro_txt = new System.Windows.Forms.TextBox();
            this.vn_note_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vn_addnotes_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vn_idnote_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vn_idpro_txt
            // 
            this.vn_idpro_txt.Enabled = false;
            this.vn_idpro_txt.Location = new System.Drawing.Point(98, 19);
            this.vn_idpro_txt.Name = "vn_idpro_txt";
            this.vn_idpro_txt.Size = new System.Drawing.Size(100, 20);
            this.vn_idpro_txt.TabIndex = 0;
            // 
            // vn_note_txt
            // 
            this.vn_note_txt.Location = new System.Drawing.Point(56, 45);
            this.vn_note_txt.Name = "vn_note_txt";
            this.vn_note_txt.Size = new System.Drawing.Size(406, 20);
            this.vn_note_txt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(537, 389);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridView1_CellContextMenuStripNeeded);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // vn_addnotes_btn
            // 
            this.vn_addnotes_btn.Location = new System.Drawing.Point(468, 42);
            this.vn_addnotes_btn.Name = "vn_addnotes_btn";
            this.vn_addnotes_btn.Size = new System.Drawing.Size(75, 23);
            this.vn_addnotes_btn.TabIndex = 3;
            this.vn_addnotes_btn.Text = "Agregar";
            this.vn_addnotes_btn.UseVisualStyleBackColor = true;
            this.vn_addnotes_btn.Click += new System.EventHandler(this.vn_addnotes_txt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vn_idnote_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vn_idpro_txt);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.vn_addnotes_btn);
            this.groupBox1.Controls.Add(this.vn_note_txt);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 473);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visor de notas del Procedimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IdProcedimiento:";
            // 
            // vn_idnote_txt
            // 
            this.vn_idnote_txt.Enabled = false;
            this.vn_idnote_txt.Location = new System.Drawing.Point(6, 45);
            this.vn_idnote_txt.Name = "vn_idnote_txt";
            this.vn_idnote_txt.Size = new System.Drawing.Size(44, 20);
            this.vn_idnote_txt.TabIndex = 5;
            this.vn_idnote_txt.TextChanged += new System.EventHandler(this.vn_idnote_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "**Doble click derecho para editar.         *Click izquierdo para borrar.";
            // 
            // viewnotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(574, 498);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "viewnotes";
            this.Text = "Visor de notas";
            this.Activated += new System.EventHandler(this.viewnotes_Activated);
            this.Load += new System.EventHandler(this.viewnotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox vn_note_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button vn_addnotes_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox vn_idpro_txt;
        public System.Windows.Forms.TextBox vn_idnote_txt;
        private System.Windows.Forms.Label label2;
    }
}