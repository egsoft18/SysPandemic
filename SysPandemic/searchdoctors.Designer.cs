namespace SysPandemic
{
    partial class searchdoctors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchdoctors));
            this.dgv_doctors = new System.Windows.Forms.DataGridView();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_idpersons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_cel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_doctorprocent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_lu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_s_name = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_adddoctor = new System.Windows.Forms.Button();
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
            this.txt_s_idpersons = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_s_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctors)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_doctors
            // 
            this.dgv_doctors.AllowUserToAddRows = false;
            this.dgv_doctors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_doctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_doctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_doctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_doctors.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_doctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_doctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_doctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_id,
            this.r_role,
            this.s_name,
            this.s_idpersons,
            this.s_sex,
            this.s_address,
            this.s_tel,
            this.s_cel,
            this.s_salary,
            this.s_doctorprocent,
            this.s_user,
            this.s_status,
            this.user2,
            this.s_lu});
            this.dgv_doctors.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_doctors.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_doctors.EnableHeadersVisualStyles = false;
            this.dgv_doctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.dgv_doctors.Location = new System.Drawing.Point(11, 108);
            this.dgv_doctors.Name = "dgv_doctors";
            this.dgv_doctors.ReadOnly = true;
            this.dgv_doctors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_doctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_doctors.RowHeadersVisible = false;
            this.dgv_doctors.RowTemplate.ReadOnly = true;
            this.dgv_doctors.Size = new System.Drawing.Size(1181, 443);
            this.dgv_doctors.TabIndex = 0;
            this.dgv_doctors.DoubleClick += new System.EventHandler(this.dgv_patients_DoubleClick);
            // 
            // s_id
            // 
            this.s_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_id.HeaderText = "ID";
            this.s_id.Name = "s_id";
            this.s_id.ReadOnly = true;
            this.s_id.Width = 47;
            // 
            // r_role
            // 
            this.r_role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.r_role.HeaderText = "Rol";
            this.r_role.Name = "r_role";
            this.r_role.ReadOnly = true;
            this.r_role.Visible = false;
            // 
            // s_name
            // 
            this.s_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_name.HeaderText = "Doctor";
            this.s_name.Name = "s_name";
            this.s_name.ReadOnly = true;
            this.s_name.Width = 78;
            // 
            // s_idpersons
            // 
            this.s_idpersons.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_idpersons.HeaderText = "Cedula";
            this.s_idpersons.Name = "s_idpersons";
            this.s_idpersons.ReadOnly = true;
            this.s_idpersons.Width = 81;
            // 
            // s_sex
            // 
            this.s_sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_sex.HeaderText = "Sexo";
            this.s_sex.Name = "s_sex";
            this.s_sex.ReadOnly = true;
            this.s_sex.Width = 67;
            // 
            // s_address
            // 
            this.s_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_address.HeaderText = "Dirección";
            this.s_address.Name = "s_address";
            this.s_address.ReadOnly = true;
            this.s_address.Width = 98;
            // 
            // s_tel
            // 
            this.s_tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_tel.HeaderText = "Teléfono";
            this.s_tel.Name = "s_tel";
            this.s_tel.ReadOnly = true;
            this.s_tel.Width = 94;
            // 
            // s_cel
            // 
            this.s_cel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_cel.HeaderText = "Celular";
            this.s_cel.Name = "s_cel";
            this.s_cel.ReadOnly = true;
            this.s_cel.Width = 81;
            // 
            // s_salary
            // 
            this.s_salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_salary.HeaderText = "Salario";
            this.s_salary.Name = "s_salary";
            this.s_salary.ReadOnly = true;
            this.s_salary.Width = 82;
            // 
            // s_doctorprocent
            // 
            this.s_doctorprocent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_doctorprocent.HeaderText = "% Ganancia";
            this.s_doctorprocent.Name = "s_doctorprocent";
            this.s_doctorprocent.ReadOnly = true;
            this.s_doctorprocent.Width = 115;
            // 
            // s_user
            // 
            this.s_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_user.HeaderText = "Usuario";
            this.s_user.Name = "s_user";
            this.s_user.ReadOnly = true;
            this.s_user.Width = 86;
            // 
            // s_status
            // 
            this.s_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_status.HeaderText = "Estado";
            this.s_status.Name = "s_status";
            this.s_status.ReadOnly = true;
            this.s_status.Width = 81;
            // 
            // user2
            // 
            this.user2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.user2.HeaderText = "Modificado por:";
            this.user2.Name = "user2";
            this.user2.ReadOnly = true;
            this.user2.Width = 140;
            // 
            // s_lu
            // 
            this.s_lu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.s_lu.HeaderText = "Fecha Modificado:";
            this.s_lu.Name = "s_lu";
            this.s_lu.ReadOnly = true;
            this.s_lu.Width = 160;
            // 
            // txt_s_name
            // 
            this.txt_s_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_name.Location = new System.Drawing.Point(271, 28);
            this.txt_s_name.Name = "txt_s_name";
            this.txt_s_name.Size = new System.Drawing.Size(576, 26);
            this.txt_s_name.TabIndex = 4;
            this.txt_s_name.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.Image = global::SysPandemic.Properties.Resources._1493284___redo;
            this.btn_refresh.Location = new System.Drawing.Point(1045, 29);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(36, 26);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // btn_adddoctor
            // 
            this.btn_adddoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_adddoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adddoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adddoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adddoctor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_adddoctor.Image = global::SysPandemic.Properties.Resources._3592854___add_user_business_man_employee_general_human_member_office;
            this.btn_adddoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adddoctor.Location = new System.Drawing.Point(1087, 29);
            this.btn_adddoctor.Name = "btn_adddoctor";
            this.btn_adddoctor.Size = new System.Drawing.Size(88, 26);
            this.btn_adddoctor.TabIndex = 6;
            this.btn_adddoctor.Text = "Agregar";
            this.btn_adddoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adddoctor.UseVisualStyleBackColor = false;
            this.btn_adddoctor.Click += new System.EventHandler(this.addpatient_btn_Click);
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
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administrar Doctores";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SysPandemic.Properties.Resources._2185059___dental_dentist;
            this.pictureBox3.Location = new System.Drawing.Point(12, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
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
            this.label1.Location = new System.Drawing.Point(476, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Administrar Doctores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb_results);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgv_doctors);
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
            this.groupBox1.Controls.Add(this.txt_s_idpersons);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_s_id);
            this.groupBox1.Controls.Add(this.txt_s_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_adddoctor);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 68);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador:";
            // 
            // txt_s_idpersons
            // 
            this.txt_s_idpersons.Location = new System.Drawing.Point(922, 28);
            this.txt_s_idpersons.Mask = "999-9999999-9";
            this.txt_s_idpersons.Name = "txt_s_idpersons";
            this.txt_s_idpersons.Size = new System.Drawing.Size(117, 26);
            this.txt_s_idpersons.TabIndex = 16;
            this.txt_s_idpersons.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_s_idpersons.Click += new System.EventHandler(this.txt_p_idperson_Click);
            this.txt_s_idpersons.TextChanged += new System.EventHandler(this.txt_p_idperson_TextChanged);
            this.txt_s_idpersons.Enter += new System.EventHandler(this.txt_p_idperson_Enter);
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
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre del Doctor:";
            // 
            // txt_s_id
            // 
            this.txt_s_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_id.Location = new System.Drawing.Point(42, 28);
            this.txt_s_id.Name = "txt_s_id";
            this.txt_s_id.Size = new System.Drawing.Size(71, 26);
            this.txt_s_id.TabIndex = 11;
            this.txt_s_id.TextChanged += new System.EventHandler(this.txt_p_id_TextChanged);
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
            // searchdoctors
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
            this.Name = "searchdoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Pacientes";
            this.Activated += new System.EventHandler(this.searchpatient_Activated);
            this.Load += new System.EventHandler(this.seepatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctors)).EndInit();
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
        private System.Windows.Forms.TextBox txt_s_name;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_adddoctor;
        private System.Windows.Forms.Button printpatientlist_btn;
        public System.Windows.Forms.DataGridView dgv_doctors;
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
        private System.Windows.Forms.TextBox txt_s_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_s_idpersons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_results;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_role;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_idpersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_cel;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_doctorprocent;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn user2;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_lu;
    }
}