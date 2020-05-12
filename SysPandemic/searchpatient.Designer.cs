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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchpatient));
            this.dgv_patients = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_idperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_bday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_telwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_affiliate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_lu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_p_name = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.addpatient_btn = new System.Windows.Forms.Button();
            this.printpatientlist_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_results = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_p_idperson = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_p_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_patients
            // 
            this.dgv_patients.AllowUserToAddRows = false;
            this.dgv_patients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_patients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_patients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_patients.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_patients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_patients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_patients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.p_name,
            this.p_idperson,
            this.p_bday,
            this.p_sex,
            this.p_address,
            this.p_tel,
            this.p_cel,
            this.p_telwork,
            this.p_email,
            this.i_name,
            this.p_affiliate,
            this.u_user,
            this.p_lu});
            this.dgv_patients.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_patients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_patients.EnableHeadersVisualStyles = false;
            this.dgv_patients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.dgv_patients.Location = new System.Drawing.Point(11, 108);
            this.dgv_patients.Name = "dgv_patients";
            this.dgv_patients.ReadOnly = true;
            this.dgv_patients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_patients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_patients.RowHeadersVisible = false;
            this.dgv_patients.RowTemplate.ReadOnly = true;
            this.dgv_patients.Size = new System.Drawing.Size(1181, 443);
            this.dgv_patients.TabIndex = 0;
            this.dgv_patients.DoubleClick += new System.EventHandler(this.dgv_patients_DoubleClick);
            // 
            // p_id
            // 
            this.p_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_id.HeaderText = "ID";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Width = 47;
            // 
            // p_name
            // 
            this.p_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_name.HeaderText = "Nombre";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            this.p_name.Width = 87;
            // 
            // p_idperson
            // 
            this.p_idperson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_idperson.HeaderText = "Cedula";
            this.p_idperson.Name = "p_idperson";
            this.p_idperson.ReadOnly = true;
            this.p_idperson.Width = 81;
            // 
            // p_bday
            // 
            this.p_bday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_bday.HeaderText = "Fecha Nac.";
            this.p_bday.Name = "p_bday";
            this.p_bday.ReadOnly = true;
            this.p_bday.Width = 111;
            // 
            // p_sex
            // 
            this.p_sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_sex.HeaderText = "Sexo";
            this.p_sex.Name = "p_sex";
            this.p_sex.ReadOnly = true;
            this.p_sex.Width = 67;
            // 
            // p_address
            // 
            this.p_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_address.HeaderText = "Dirección";
            this.p_address.Name = "p_address";
            this.p_address.ReadOnly = true;
            this.p_address.Width = 98;
            // 
            // p_tel
            // 
            this.p_tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_tel.HeaderText = "Teléfono";
            this.p_tel.Name = "p_tel";
            this.p_tel.ReadOnly = true;
            this.p_tel.Width = 94;
            // 
            // p_cel
            // 
            this.p_cel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_cel.HeaderText = "Celular";
            this.p_cel.Name = "p_cel";
            this.p_cel.ReadOnly = true;
            this.p_cel.Width = 81;
            // 
            // p_telwork
            // 
            this.p_telwork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_telwork.HeaderText = "Tel. Trabajo";
            this.p_telwork.Name = "p_telwork";
            this.p_telwork.ReadOnly = true;
            this.p_telwork.Width = 118;
            // 
            // p_email
            // 
            this.p_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_email.HeaderText = "Email";
            this.p_email.Name = "p_email";
            this.p_email.ReadOnly = true;
            this.p_email.Width = 71;
            // 
            // i_name
            // 
            this.i_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.i_name.HeaderText = "ARS";
            this.i_name.Name = "i_name";
            this.i_name.ReadOnly = true;
            this.i_name.Width = 63;
            // 
            // p_affiliate
            // 
            this.p_affiliate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_affiliate.HeaderText = "No. Afiliado";
            this.p_affiliate.Name = "p_affiliate";
            this.p_affiliate.ReadOnly = true;
            this.p_affiliate.Width = 113;
            // 
            // u_user
            // 
            this.u_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.u_user.HeaderText = "Modificado Por:";
            this.u_user.Name = "u_user";
            this.u_user.ReadOnly = true;
            this.u_user.Width = 141;
            // 
            // p_lu
            // 
            this.p_lu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_lu.HeaderText = "Fec. Modificado:";
            this.p_lu.Name = "p_lu";
            this.p_lu.ReadOnly = true;
            this.p_lu.Width = 147;
            // 
            // txt_p_name
            // 
            this.txt_p_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_name.Location = new System.Drawing.Point(285, 28);
            this.txt_p_name.Name = "txt_p_name";
            this.txt_p_name.Size = new System.Drawing.Size(562, 26);
            this.txt_p_name.TabIndex = 4;
            this.txt_p_name.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search_btn.Image = global::SysPandemic.Properties.Resources._1493284___redo;
            this.search_btn.Location = new System.Drawing.Point(1045, 29);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(36, 26);
            this.search_btn.TabIndex = 5;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // addpatient_btn
            // 
            this.addpatient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.addpatient_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpatient_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addpatient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpatient_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addpatient_btn.Image = global::SysPandemic.Properties.Resources._3592854___add_user_business_man_employee_general_human_member_office;
            this.addpatient_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addpatient_btn.Location = new System.Drawing.Point(1087, 29);
            this.addpatient_btn.Name = "addpatient_btn";
            this.addpatient_btn.Size = new System.Drawing.Size(88, 26);
            this.addpatient_btn.TabIndex = 6;
            this.addpatient_btn.Text = "Agregar";
            this.addpatient_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addpatient_btn.UseVisualStyleBackColor = false;
            this.addpatient_btn.Click += new System.EventHandler(this.addpatient_btn_Click);
            // 
            // printpatientlist_btn
            // 
            this.printpatientlist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.printpatientlist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printpatientlist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printpatientlist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.printpatientlist_btn.Image = global::SysPandemic.Properties.Resources._1493286___print;
            this.printpatientlist_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printpatientlist_btn.Location = new System.Drawing.Point(1092, 557);
            this.printpatientlist_btn.Name = "printpatientlist_btn";
            this.printpatientlist_btn.Size = new System.Drawing.Size(100, 24);
            this.printpatientlist_btn.TabIndex = 8;
            this.printpatientlist_btn.Text = "Imprimir";
            this.printpatientlist_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printpatientlist_btn.UseVisualStyleBackColor = false;
            this.printpatientlist_btn.Click += new System.EventHandler(this.printpatientlist_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(-12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 21);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(39, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administrar Pacientes";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SysPandemic.Properties.Resources._3592853___align_employee_general_human_human_list_list_member;
            this.pictureBox3.Location = new System.Drawing.Point(12, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1158, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1186, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Administrar Pacientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb_results);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgv_patients);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.printpatientlist_btn);
            this.panel2.Location = new System.Drawing.Point(1, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 2, 2);
            this.panel2.Size = new System.Drawing.Size(1203, 586);
            this.panel2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(241, 557);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total de Registros:";
            // 
            // lb_results
            // 
            this.lb_results.AutoSize = true;
            this.lb_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_results.Location = new System.Drawing.Point(146, 555);
            this.lb_results.Name = "lb_results";
            this.lb_results.Size = new System.Drawing.Size(29, 20);
            this.lb_results.TabIndex = 18;
            this.lb_results.Text = "##";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_p_idperson);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_p_id);
            this.groupBox1.Controls.Add(this.txt_p_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addpatient_btn);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 68);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador:";
            // 
            // txt_p_idperson
            // 
            this.txt_p_idperson.Location = new System.Drawing.Point(922, 28);
            this.txt_p_idperson.Mask = "999-9999999-9";
            this.txt_p_idperson.Name = "txt_p_idperson";
            this.txt_p_idperson.Size = new System.Drawing.Size(117, 26);
            this.txt_p_idperson.TabIndex = 16;
            this.txt_p_idperson.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_p_idperson.Click += new System.EventHandler(this.txt_p_idperson_Click);
            this.txt_p_idperson.TextChanged += new System.EventHandler(this.txt_p_idperson_TextChanged);
            this.txt_p_idperson.Enter += new System.EventHandler(this.txt_p_idperson_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre del Paciente:";
            // 
            // txt_p_id
            // 
            this.txt_p_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_id.Location = new System.Drawing.Point(42, 28);
            this.txt_p_id.Name = "txt_p_id";
            this.txt_p_id.Size = new System.Drawing.Size(71, 26);
            this.txt_p_id.TabIndex = 11;
            this.txt_p_id.TextChanged += new System.EventHandler(this.txt_p_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(853, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cedula:";
            // 
            // searchpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1205, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "searchpatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Pacientes";
            this.Load += new System.EventHandler(this.seepatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_p_name;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button addpatient_btn;
        private System.Windows.Forms.Button printpatientlist_btn;
        public System.Windows.Forms.DataGridView dgv_patients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_p_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_p_idperson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_idperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_bday;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_telwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_affiliate;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_lu;
        public System.Windows.Forms.TextBox textBox1;
    }
}