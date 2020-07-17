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
    public partial class searchsuppliers : Form
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

        public searchsuppliers()
        {
            InitializeComponent();
        }
        //Funcion especifica para movilidad del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        /********** FUNCIONES & METODOS **********/
        
        private void load_suppliers_dgv()
        {

            SqlCommand comando = new SqlCommand();

            SqlDataReader dr;
            comando.Connection = c.cnx;


            string query = "SELECT TOP (1000) [pv_id], [pv_name], [pv_address], [pv_phone], [pv_email], [pv_contact], [pv_contactposition], [pv_phonecontact], [pv_status], u.u_user, [pv_lu] FROM [dbo].[provider] as p inner join users as u on u.u_id = p.u_id where[pv_id] like '%" + txt_pv_id.Text + "%' and [pv_name] like '%" + txt_pv_name.Text + "%' order by pv_name desc";

            comando.CommandText = query;

            comando.CommandType = CommandType.Text;
            DataGridView dgv = dgv_suppliers;
            dgv.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgv.Rows.Add();

                dgv.Rows[renglon].Cells["pv_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("pv_id")));
                dgv.Rows[renglon].Cells["pv_name"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("pv_name")));
                dgv.Rows[renglon].Cells["pv_address"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("pv_address")));
                dgv.Rows[renglon].Cells["pv_phone"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("pv_phone")));
                dgv.Rows[renglon].Cells["pv_contact"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("pv_contact")));
                dgv.Rows[renglon].Cells["pv_phonecontact"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("pv_phonecontact")));
                
                if(dr.GetInt32(dr.GetOrdinal("pv_status")) == 1)
                {
                    dgv.Rows[renglon].Cells["pv_status"].Value = "Activo";
                }
                else
                {
                    dgv.Rows[renglon].Cells["pv_status"].Value = "Inactivo";
                }

                dgv.Rows[renglon].Cells["u_id"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("u_user")));
                dgv.Rows[renglon].Cells["pv_lu"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("pv_lu")).ToString("dd/MM/yyyy"));

            }
            lb_results.Text = dgv_suppliers.Rows.Count.ToString();
        }

        /********** FIN DE FUNCIONES & METODOS **********/
       
        private void search_btn_Click(object sender, EventArgs e)
        {
            load_suppliers_dgv();
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

        private void txt_pv_id_TextChanged(object sender, EventArgs e)
        {
            load_suppliers_dgv();
        }

        private void txt_pv_name_TextChanged(object sender, EventArgs e)
        {
            load_suppliers_dgv();
        }

        private void btn_addsupplier_Click(object sender, EventArgs e)
        {
            addsupplier f = new addsupplier();

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addsupplier);
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

        private void dgv_suppliers_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dgv_suppliers.Rows[dgv_suppliers.CurrentRow.Index].Cells["pv_id"].Value.ToString();

            if (formulario_devolver == true)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (formulario_devolver == false)
            {
                addsupplier f = new addsupplier();
                f.formulario_devolver = true;
                f.txt_pv_id.Text = dgv_suppliers.Rows[dgv_suppliers.CurrentRow.Index].Cells["pv_id"].Value.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    load_suppliers_dgv();
                }
            }
        }

        private void searchsuppliers_Load(object sender, EventArgs e)
        {
            load_suppliers_dgv();
        }
    }
}
