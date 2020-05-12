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
    public partial class searchinsurances : Form
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

        public searchinsurances()
        {
            InitializeComponent();
        }
        //Funcion especifica para movilidad del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        /********** FUNCIONES & METODOS **********/
        
        private void load_insurance_dgv()
        {

            SqlCommand comando = new SqlCommand();

            SqlDataReader dr;
            comando.Connection = c.cnx;


            string query = "SELECT [i_id], [i_name], [i_contract], [i_pss], isnull([i_telephone], '') as i_telephone, isnull([i_email], '') as i_email, [i_status], u.u_user, [i_lu] FROM [dbo].[insurances] as i inner join [dbo].[users] as u on i.u_id = u.u_id where [i_id] like '%" + txt_i_id.Text+ "%' and [i_name] like '%" + txt_i_name.Text+ "%' and [i_contract] like '%" + txt_i_contract.Text+"%'";

            comando.CommandText = query;

            comando.CommandType = CommandType.Text;
            DataGridView dgv = dgv_insurance;
            dgv.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgv.Rows.Add();

                dgv.Rows[renglon].Cells["i_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("i_id")));
                dgv.Rows[renglon].Cells["i_name"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("i_name")));
                dgv.Rows[renglon].Cells["i_contract"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("i_contract")));
                dgv.Rows[renglon].Cells["i_pss"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("i_pss")));
                dgv.Rows[renglon].Cells["i_telephone"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("i_telephone")));
                dgv.Rows[renglon].Cells["i_email"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("i_email")));

                //dgv.Rows[renglon].Cells["i_status"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("i_status")));
                if(Convert.ToInt32(dr.GetInt32(dr.GetOrdinal("i_status"))) == 1)
                {
                    dgv.Rows[renglon].Cells["i_status"].Value = "Activo";
                }
                else
                {
                    dgv.Rows[renglon].Cells["i_status"].Value = "inactivo";
                }
                dgv.Rows[renglon].Cells["u_id"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("u_user")));
                dgv.Rows[renglon].Cells["i_lu"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("i_lu")).ToString("dd/MM/yyyy"));

            }
            lb_results.Text = dgv_insurance.Rows.Count.ToString();
        }

        /********** FIN DE FUNCIONES & METODOS **********/
        private void seepatient_Load(object sender, EventArgs e)
        {
            load_insurance_dgv();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            load_insurance_dgv();
        }

        private void addpatient_btn_Click(object sender, EventArgs e)
        {
            addinsurance f = new addinsurance();

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addinsurance);
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
            load_insurance_dgv();
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
            load_insurance_dgv();
        }

        private void dgv_patients_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dgv_insurance.Rows[dgv_insurance.CurrentRow.Index].Cells["i_id"].Value.ToString();

            if (formulario_devolver == true)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (formulario_devolver == false)
            {
                addinsurance f = new addinsurance();
                f.formulario_devolver = true;
                f.txt_i_id.Text = dgv_insurance.Rows[dgv_insurance.CurrentRow.Index].Cells["i_id"].Value.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    load_insurance_dgv();
                }
            }
        }

        private void txt_i_contract_TextChanged(object sender, EventArgs e)
        {
            load_insurance_dgv();
        }
    }
}
