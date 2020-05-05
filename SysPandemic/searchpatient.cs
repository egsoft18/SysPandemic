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
    public partial class searchpatient : Form
    {
        /********** GLOSARIO **********/
        // txt = TextBox or MaskedTextBox
        // cb = ComboBox
        // btn = Button
        // cbx = CheckBox
        // dtp = DateTimePicker
        // dgv = DataGridView
        // gb = GroupBox

        // p = patient (paciente)
        // pm = patient's medical (Diagnostico Medico)
        // ph = patient's historial (Historial del Paciente)


        //SqlCommand cmd;
        //SqlDataReader dr;

        OpenDB c = new OpenDB();

        public bool formulario_devolver = false;

        public searchpatient()
        {
            InitializeComponent();
        }
        //Funcion especifica para movilidad del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        /********** FUNCIONES & METODOS **********/
        
        private void load_patients_dgv()
        {

            SqlCommand comando = new SqlCommand();

            SqlDataReader dr;
            comando.Connection = c.cnx;


            string query = "SELECT [p_id], [p_name], [p_idperson], [p_bday], [p_sex], [p_address], [p_tel], [p_cel], [p_telwork], [p_email], i.[i_name], [p_affiliate], u.u_user, [p_lu] FROM [dbo].[patient] as p inner join [dbo].[insurances] as i on i.i_id = p.i_id inner join [dbo].[users] as u on u.u_id = p.u_id  where [p_id] like '%"+txt_p_id.Text+"%'  and [p_name] like '%"+txt_p_name.Text+ "%' and [p_idperson] like '%"+txt_p_idperson.Text+"%'";

            comando.CommandText = query;

            comando.CommandType = CommandType.Text;
            DataGridView dgv = dgv_patients;
            dgv.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgv.Rows.Add();

                dgv.Rows[renglon].Cells["p_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("p_id")));
                dgv.Rows[renglon].Cells["p_name"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_name")));
                dgv.Rows[renglon].Cells["p_idperson"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_idperson")));
                dgv.Rows[renglon].Cells["p_bday"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("p_bday")).ToString("dd/MM/yyyy"));
                dgv.Rows[renglon].Cells["p_sex"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_sex")));
                dgv.Rows[renglon].Cells["p_address"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_address")));
                dgv.Rows[renglon].Cells["p_tel"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_tel")));
                dgv.Rows[renglon].Cells["p_cel"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_cel")));
                dgv.Rows[renglon].Cells["p_telwork"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_telwork")));
                dgv.Rows[renglon].Cells["p_email"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_email")));
                dgv.Rows[renglon].Cells["i_name"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("i_name")));
                dgv.Rows[renglon].Cells["p_affiliate"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_affiliate")));

                dgv.Rows[renglon].Cells["u_user"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("u_user")));
                dgv.Rows[renglon].Cells["p_lu"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("p_lu")).ToString("dd/MM/yyyy"));

            }
            lb_results.Text = dgv_patients.Rows.Count.ToString();
        }

        /********** FIN DE FUNCIONES & METODOS **********/
        private void seepatient_Load(object sender, EventArgs e)
        {
            load_patients_dgv();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void sid_rbtn_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            load_patients_dgv();
        }

        private void refreshpatient_btn_Click(object sender, EventArgs e)
        {
        }

        private void addpatient_btn_Click(object sender, EventArgs e)
        {
            AddPatient f = new AddPatient();

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AddPatient);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            load_patients_dgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void searchpatient_Activated(object sender, EventArgs e)
        {
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
            load_patients_dgv();
        }

        private void txt_p_idperson_TextChanged(object sender, EventArgs e)
        {
            load_patients_dgv();
        }

        private void txt_p_idperson_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_idperson);
        }

        private void txt_p_idperson_Enter(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_idperson);
        }

        private void dgv_patients_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dgv_patients.Rows[dgv_patients.CurrentRow.Index].Cells["p_id"].Value.ToString();

            if (formulario_devolver == true)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (formulario_devolver == false)
            {
                AddPatient f = new AddPatient();
                f.formulario_devolver = true;
                f.txt_p_id.Text = dgv_patients.Rows[dgv_patients.CurrentRow.Index].Cells["p_id"].Value.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    load_patients_dgv();
                }
            }
        }
    }
}
