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
    public partial class searchappointment : Form
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

        public searchappointment()
        {
            InitializeComponent();
        }
        //Funcion especifica para movilidad del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        /********** FUNCIONES & METODOS **********/
        
        public void load_appointment_dgv(string lb)
        {

            SqlCommand comando = new SqlCommand();

            SqlDataReader dr;
            comando.Connection = c.cnx;

            string query = "";
            if (lb == "l")
            {
                query = "SELECT TOP (1000) [dm_id], cast(case when dt.[dm_status] = '1' then 'Agendada' when dt.[dm_status] = '2' then 'Asitencia' when dt.[dm_status] = '3' then 'Atendida' when dt.[dm_status] = '0' then 'Cancelada' end as nvarchar) as 'dm_status', [dm_turn], p.p_name, s.s_name, [dm_date],  u.u_user, [dm_lu] FROM [dbo].[datem] as dt inner join [dbo].[patient] as p on p.p_id = dt.p_id inner join [dbo].[staff] as s on s.s_id = dt.s_id inner join [dbo].[users] as u on u.u_id = dt.u_id where CONVERT(VARCHAR(25), dm_date, 126) like CONCAT('" + Convert.ToDateTime(dtp_dm_date.Text).ToString("yyyy-MM-dd") + "','%')";               
            }
            else if (lb == "b")
            {
                if (cbx_date.Checked)
                {
                    query = "SELECT TOP (1000) [dm_id], cast(case when dt.[dm_status] = '1' then 'Agendada' when dt.[dm_status] = '2' then 'Asitencia' when dt.[dm_status] = '3' then 'Atendida' when dt.[dm_status] = '0' then 'Cancelada' end as nvarchar) as 'dm_status', [dm_turn], p.p_name, s.s_name, [dm_date],  u.u_user, [dm_lu] FROM [dbo].[datem] as dt inner join [dbo].[patient] as p on p.p_id = dt.p_id inner join [dbo].[staff] as s on s.s_id = dt.s_id inner join [dbo].[users] as u on u.u_id = dt.u_id where dm_id like '%" + txt_dm_id.Text + "%' and p_name like '%" + txt_p_name.Text + "%' and s.s_name like '%" + txt_s_name.Text + "%' and CONVERT(VARCHAR(25), dm_date, 126) like CONCAT('" + Convert.ToDateTime(dtp_dm_date.Text).ToString("yyyy-MM-dd") + "','%')";
                }
                else
                {
                    query = "SELECT TOP (1000) [dm_id], cast(case when dt.[dm_status] = '1' then 'Agendada' when dt.[dm_status] = '2' then 'Asitencia' when dt.[dm_status] = '3' then 'Atendida' when dt.[dm_status] = '0' then 'Cancelada' end as nvarchar) as 'dm_status', [dm_turn], p.p_name, s.s_name, [dm_date],  u.u_user, [dm_lu] FROM [dbo].[datem] as dt inner join [dbo].[patient] as p on p.p_id = dt.p_id inner join [dbo].[staff] as s on s.s_id = dt.s_id inner join [dbo].[users] as u on u.u_id = dt.u_id where dm_id like '%" + txt_dm_id.Text + "%' and p_name like '%" + txt_p_name.Text + "%' and s.s_name like '%" + txt_s_name.Text + "%'";
                }
            }

            comando.CommandText = query;

            comando.CommandType = CommandType.Text;
            DataGridView dgv = dgv_appointment;
            dgv.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgv.Rows.Add();

                dgv.Rows[renglon].Cells["dm_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("dm_id")));
                dgv.Rows[renglon].Cells["dm_status"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("dm_status")));
                dgv.Rows[renglon].Cells["dm_turn"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("dm_turn")));
                dgv.Rows[renglon].Cells["p_name"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("p_name")));
                dgv.Rows[renglon].Cells["s_name"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("s_name")));
                dgv.Rows[renglon].Cells["dm_date"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("dm_date")));
                dgv.Rows[renglon].Cells["u_id"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("u_user")));
                dgv.Rows[renglon].Cells["dm_lu"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("dm_lu")).ToString("dd/MM/yyyy"));                
            }
            lb_results.Text = dgv_appointment.Rows.Count.ToString();
        }

        /********** FIN DE FUNCIONES & METODOS **********/
        
        private void search_btn_Click(object sender, EventArgs e)
        {
            load_appointment_dgv("b");
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

        private void txt_dm_id_TextChanged(object sender, EventArgs e)
        {
            load_appointment_dgv("b");
        }

        private void txt_p_name_TextChanged(object sender, EventArgs e)
        {
            load_appointment_dgv("b");
        }

        private void txt_s_name_TextChanged(object sender, EventArgs e)
        {
            load_appointment_dgv("b");
        }

        private void dtp_dm_date_ValueChanged(object sender, EventArgs e)
        {
            load_appointment_dgv("b");
        }

        private void btn_adddoctor_Click(object sender, EventArgs e)
        {
            addappointment f = new addappointment();

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addappointment);
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

        private void searchappointment_Load(object sender, EventArgs e)
        {
            cbx_date.Checked = true;
            load_appointment_dgv("l");
        }

        private void dgv_appointment_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dgv_appointment.Rows[dgv_appointment.CurrentRow.Index].Cells["dm_id"].Value.ToString();

            if (formulario_devolver == true)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (formulario_devolver == false)
            {
                addappointment f = new addappointment();
                f.formulario_devolver = true;
                f.txt_dm_id.Text = dgv_appointment.Rows[dgv_appointment.CurrentRow.Index].Cells["dm_id"].Value.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    load_appointment_dgv("b");
                }
            }
        }

        private void cbx_date_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_date.Checked)
            {
                dtp_dm_date.Enabled = true;
            }
            else
            {
                dtp_dm_date.Enabled = false;
            }
        }
    }
}
