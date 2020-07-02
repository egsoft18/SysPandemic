using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SysPandemic
{
    public partial class searchdoctors : Form
    {
        /********** GLOSARIO **********/
        // txt = TextBox or MaskedTextBox
        // cb = ComboBox
        // btn = Button
        // cbx = CheckBox
        // dtp = DateTimePicker
        // dgv = DataGridView
        // gb = GroupBox


        //SqlCommand cmd;
        //SqlDataReader dr;

        OpenDB c = new OpenDB();

        public bool formulario_devolver = false;

        public searchdoctors()
        {
            InitializeComponent();
        }
        //Funcion especifica para movilidad del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        /********** FUNCIONES & METODOS **********/
        
        public void load_doctors_dgv()
        {

            SqlCommand comando = new SqlCommand();

            SqlDataReader dr;
            comando.Connection = c.cnx;


            string query = "SELECT [s_id], u1.u_user, r.r_role, [s_name], [s_sex], [s_idpersons], [s_address], [s_tel], [s_cel], [s_salary], [s_doctorprocent], [s_status], u2.u_user as user2, [s_lu] FROM [dbo].[staff] as s inner join [dbo].[users] as u1 on u1.u_id = s.s_user inner join [dbo].[users] as u2 on u2.u_id = s.u_id inner join roles as r on r.r_id = s.r_id  where s.[r_id] = 2 and [s_id] like '%" + txt_s_id.Text+ "%'  and [s_name] like '%" + txt_s_name.Text+ "%' and [s_idpersons] like '%" + txt_s_idpersons.Text+"%'";

            comando.CommandText = query;

            comando.CommandType = CommandType.Text;
            DataGridView dgv = dgv_doctors;
            dgv.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgv.Rows.Add();
                
                dgv.Rows[renglon].Cells["s_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("s_id")));
                dgv.Rows[renglon].Cells["s_user"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("u_user")));
                dgv.Rows[renglon].Cells["r_role"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("r_role")));
                dgv.Rows[renglon].Cells["s_name"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("s_name")));
                dgv.Rows[renglon].Cells["s_sex"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("s_sex")));
                dgv.Rows[renglon].Cells["s_idpersons"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("s_idpersons")));
                dgv.Rows[renglon].Cells["s_address"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("s_address")));
                dgv.Rows[renglon].Cells["s_tel"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("s_tel")));
                dgv.Rows[renglon].Cells["s_cel"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("s_cel")));
                dgv.Rows[renglon].Cells["s_salary"].Value = "RD$ "+Convert.ToString(dr.GetDecimal(dr.GetOrdinal("s_salary")));
                dgv.Rows[renglon].Cells["s_doctorprocent"].Value = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("s_doctorprocent"))) + "%";
                //dgv.Rows[renglon].Cells["s_status"].Value = Convert.ToString(dr.(dr.GetOrdinal("")));
                if (Convert.ToInt32(dr.GetInt32(dr.GetOrdinal("s_status"))) == 0)
                {
                    dgv.Rows[renglon].Cells["s_status"].Value = "Inactivo";
                }
                else
                {
                    dgv.Rows[renglon].Cells["s_status"].Value = "Activo";
                }

                dgv.Rows[renglon].Cells["user2"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("user2")));
                dgv.Rows[renglon].Cells["s_lu"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("s_lu")).ToString("dd/MM/yyyy"));


            }
            lb_results.Text = dgv_doctors.Rows.Count.ToString();
        }

        /********** FIN DE FUNCIONES & METODOS **********/
        private void seepatient_Load(object sender, EventArgs e)
        {
            load_doctors_dgv();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            load_doctors_dgv();
        }

        private void addpatient_btn_Click(object sender, EventArgs e)
        {
            adddoctor f = new adddoctor();

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is adddoctor);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printpatientlist_btn_Click(object sender, EventArgs e)
        {
           // DBManager c = new DBManager();
           //try
           // {
           //     if (search_txt.Text.Length == 0)
           //     {
           //         string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient";
           //         string tablename = "Pacientes";
           //         string xml = "listpatient.xml";
           //         string report = "listpatient.rpt";
           //         c.printreport(query, tablename, xml, report);
                    
           //     }
           //     else if (sid_rbtn.Checked)
           //     {
           //         string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where id like '%" + search_txt.Text + "%'";
           //         string tablename = "Pacientes";
           //         string xml = "listpatient.xml";
           //         string report = "listpatient.rpt";
           //         c.printreport(query, tablename, xml, report);

           //     }
           //     else if (sname_rbtn.Checked)
           //     {
           //         string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where name like '%" + search_txt.Text + "%'";
           //         string tablename = "Pacientes";
           //         string xml = "listpatient.xml";
           //         string report = "listpatient.rpt";
           //         c.printreport(query, tablename, xml, report);
           //     }
           //     else if (sidperson_rbtn.Checked)
           //     {
           //         string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where idperson like '%" + search_txt.Text + "%'";
           //         string tablename = "Pacientes";
           //         string xml = "listpatient.xml";
           //         string report = "listpatient.rpt";
           //         c.printreport(query, tablename, xml, report);
           //     }
           //     else
           //     {
           //         string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient";
           //         string tablename = "Pacientes";
           //         string xml = "listpatient.xml";
           //         string report = "listpatient.rpt";
           //         c.printreport(query, tablename, xml, report);
           //     }

           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.Message, "Error");
           // }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            load_doctors_dgv();
        }

        private void searchpatient_Activated(object sender, EventArgs e)
        {
            load_doctors_dgv();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Esta parte va en el evento MouseDown del panel en la parte superior del formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_p_id_TextChanged(object sender, EventArgs e)
        {
            load_doctors_dgv();
        }

        private void txt_p_idperson_TextChanged(object sender, EventArgs e)
        {
            load_doctors_dgv();
        }

        private void txt_p_idperson_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_s_idpersons);
        }

        private void txt_p_idperson_Enter(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_s_idpersons);
        }

        private void dgv_patients_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dgv_doctors.Rows[dgv_doctors.CurrentRow.Index].Cells["s_id"].Value.ToString();

            if (formulario_devolver == true)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (formulario_devolver == false)
            {
                adddoctor f = new adddoctor();
                f.formulario_devolver = true;
                f.txt_s_id.Text = dgv_doctors.Rows[dgv_doctors.CurrentRow.Index].Cells["s_id"].Value.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    load_doctors_dgv();
                }
            }
        }
    }
}
