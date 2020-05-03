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
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace SysPandemic
{
    public partial class AddPatient : Form
    {
        //DBManager c = new DBManager();

        SqlCommand cmd;
        SqlDataReader dr;

        OpenDB c = new OpenDB();

        public bool formulario_devolver = false;
        public AddPatient()
        {
            InitializeComponent();
        }





        //Esta parte va debajo del public del formulario, fuera de las llavez de este.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
        }

        private void printpatient_btn_Click(object sender, EventArgs e)
        {
        //    DBManager c = new DBManager();
        //    string query = "select * from patient p, medicald md where p.idpatient = md.idpatient and p.idpatient = '" + idpatient_txt.Text + "'";

        //    string tablename = "patient";
        //    string xml = "patient.xml";
        //    string report = "Reports/patient.rpt";
        //    c.printreport(query, tablename, xml, report);

        }

        private void savepatient_txt_Click(object sender, EventArgs e)
        {

        }

        private void updatepatient_btn_Click(object sender, EventArgs e)
        {
        }

        private void clearform_btn_Click(object sender, EventArgs e)
        {
            foreach (Control oControls in this.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "";
                }
            }

            foreach (ComboBox oControls in this.Controls)
            {
                if (oControls.SelectedValue == null)
                {
                    oControls.SelectedIndex = -1;
                }
            }

            foreach (DataGridView oControls in this.Controls)
            {
                if (oControls.Rows.Count > 0)
                {
                    oControls.Rows.Clear();
                }
            }
        }

        private void delatepatient_btn_Click(object sender, EventArgs e)
        {
         

            //DBManager c = new DBManager();
            //DialogResult result = MessageBox.Show("Seguro que desea borra este paciente?, Al borrar el paciente solo se inhabilita la opción de agregarle procedimientos o citas, pero este seguirá apareciendo en los registros necesarios.", "Borrar datos del Paciente", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            // string query = "DELETE FROM patient WHERE idpatient = '" + idpatient_txt.Text + "'";
            // c.command(query);
            //if (c.valor == "si")
            //{
            //    this.Close();
            //}
            //    }
            //    else if (result == DialogResult.No)
            //    {

            //    }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                //DBManager c = new DBManager();
                ////string query = "select * from medicald where idpatient = '" + idpatient_md_txt.Text + "'";
                ////c.command3(query);
                ////MessageBox.Show("valor de valor " + c.valor);
                //try
                //{
                //    string query2 = "UPDATE medicald Set tmed = '" + tmed_cb.Text + "', tmedcom = '" + tmedcom_txt.Text + "', mica = '" + mica_cb.Text + "', micacom = '" + micacom_txt.Text + "', ps = '" + ps_cb.Text + "', diab = '" + diab_cb.Text + "', hep = '" + hep_cb.Text + "', hepcom = '" + hepcom_txt.Text + "', pr = '" + pr_cb.Text + "', pe = '" + pe_cb.Text + "', pecom = '" + pecom_txt.Text + "', pa = '" + pa_cb.Text + "', pacom = '" + pacom_txt.Text + "', hemo = '" + hemo_cb.Text + "', aler = '" + aler_cb.Text + "', alercom = '" + alercom_txt.Text + "' WHERE idpatient = '" + idpatient_md_txt.Text + "';";
                //    c.command(query2);
                //    //c.valor = "no";
                //}
                //catch
                //{
                //    string query3 = "INSERT INTO medicald(idpatient, tmed, tmedcom, mica, micacom, ps, diab, hep, hepcom, pr, pe, pecom, pa, pacom, hemo, aler, alercom) VALUES ('" + idpatient_md_txt.Text + "', '" + tmed_cb.Text + "', '" + tmedcom_txt.Text + "', '" + mica_cb.Text + "', '" + micacom_txt.Text + "', '" + ps_cb.Text + "', '" + diab_cb.Text + "', '" + hep_cb.Text + "', '" + hepcom_txt.Text + "', '" + pr_cb.Text + "', '" + pe_cb.Text + "', '" + pecom_txt.Text + "', '" + pa_cb.Text + "', '" + pacom_txt.Text + "', '" + hemo_cb.Text + "', '" + aler_cb.Text + "', '" + alercom_txt.Text + "')";
                //    c.command(query3);
                //}
        }

        private void namep_md_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void telpatient_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void celpatient_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tworkpatient_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void searchhistory_txt_TextChanged(object sender, EventArgs e)
        {
            //DBManager c = new DBManager();
            //string query = "select idhistory as ID, diente as Diente, activity as Actividad, abono as Abono, date as Fecha from patienthistory where idpatient like '%" + searchhistory_txt.Text + "%'";
            //c.load_dgv(patienthistory, query);
        }

        private void insurancepatient_txt_Click(object sender, EventArgs e)
        {
            
        }

        private void insurancepatient_txt_MouseClick(object sender, MouseEventArgs e)
        {
            //if(insurancepatient_txt.Items.Count <= 0)
            //{
            //    string query3 = "Select idinsurance, nameinsurance from insurances";
            //    string item = "nameinsurance";
            //    c.fill_CB(insurancepatient_txt, query3, item);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb_pm_tmed.Text = "No";
            cb_pm_mica.Text = "No";
            cb_pm_ps.Text = "No";
            cb_pm_diab.Text = "No";
            cb_pm_hep.Text = "No";
            cb_pm_pr.Text = "No";
            cb_pm_pe.Text = "No";
            cb_pm_pa.Text = "No";
            cb_pm_hemo.Text = "No";
            cb_pm_aler.Text = "No";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void AddPatient_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchpatient f = new searchpatient();
            f.formulario_devolver = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                //limpiar();
                //txt_p_id.Text = f.textBox1.Text;
            }
        }
    }
}
