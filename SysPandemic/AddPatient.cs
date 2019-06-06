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

namespace SysPandemic
{
    public partial class AddPatient : Form
    {
        DBManager c = new DBManager();
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
            //if (idpatient_txt.Text )


            DBManager c2 = new DBManager();
            string query = "select idhistory as ID, tooth as Diente, activity as Actividad, qtypay as Abono, date as Fecha from patienthistory where idpatient = '"+ idpatient_txt.Text+"'";
            c2.load_dgv(patienthistory, query);
            

                idpatient_md_txt.Text = idpatient_txt.Text;
                namep_md_txt.Text = namepatient_txt.Text;
                idph_txt.Text = idpatient_txt.Text;
            
            
            
            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    string cmd = "Select idinsurance, nameinsurance from insurances";
            //    SQLiteDataAdapter dept = new SQLiteDataAdapter(cmd, cnx);
            //    DataTable user = new DataTable();
            //    dept.Fill(user);
            //    insurancepatient_txt.DataSource = user;
            //    insurancepatient_txt.DisplayMember = "nameinsurance";
            //    insurancepatient_txt.ValueMember = "idinsurance";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void printpatient_btn_Click(object sender, EventArgs e)
        {
            DBManager c = new DBManager();
            string query = "select * from patient p, medicald md where p.idpatient = md.idpatient and p.idpatient = '" + idpatient_txt.Text + "'";
            
            string tablename = "patient";
            string xml = "patient.xml";
            string report = "patient.rpt";
            c.printreport(query, tablename, xml, report);

            
            
            //SQLiteDataAdapter ad;
            //DataTable dt = new DataTable();
            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    SQLiteCommand cmd = cnx.CreateCommand();
            //    cmd.CommandText = "Select * from patient where id = '" + idpatient_txt.Text + "'";
            //    ad = new SQLiteDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    ad.Fill(dt);
            //    ds.Tables.Add(dt);
            //    ds.Tables[0].TableName = "Empleados";
            //    ds.WriteXml(@"C:\SysPandemic\xml\patient.xml");
            //    //MessageBox.Show("Done");
            //    reportview rv = new reportview("patient.rpt");
            //    rv.Show();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");

            //}
        }

        private void savepatient_txt_Click(object sender, EventArgs e)
        {

            DBManager c = new DBManager();
            string query = "UPDATE patient set name = '" + namepatient_txt.Text + "', sex = '" + sexpatient_cb.Text + "', bday = '" + bdaypatient_dtp.Text + "', idperson = '" + idperson_txt.Text + "', address = '" + addresspatient_txt.Text + "', tel = '" + telpatient_txt.Text + "', cel = '" + celpatient_txt.Text + "', telwork = '" + tworkpatient_txt.Text + "', insurance = '" + insurancepatient_txt.Text + "', affiliate = '" + affiliatepatient_txt.Text + "' WHERE idpatient = '" + idpatient_txt.Text + "'";
            c.command(query);
            string query5 = "INSERT INTO medicald(idpatient, tmed, tmedcom, mica, micacom, ps, diab, hep, hepcom, pr, pe, pecom, pa, pacom, hemo, aler, alercom) VALUES ('" + idpatient_md_txt.Text + "', '" + tmed_cb.Text + "', '" + tmedcom_txt.Text + "', '" + mica_cb.Text + "', '" + micacom_txt.Text + "', '" + ps_cb.Text + "', '" + diab_cb.Text + "', '" + hep_cb.Text + "', '" + hepcom_txt.Text + "', '" + pr_cb.Text + "', '" + pe_cb.Text + "', '" + pecom_txt.Text + "', '" + pa_cb.Text + "', '" + pacom_txt.Text + "', '" + hemo_cb.Text + "', '" + aler_cb.Text + "', '" + alercom_txt.Text + "')";
            c.command3(query5);


            if (c.valor == "si")
            {
                namepatient_txt.Clear();
                sexpatient_cb.Text = "";
                idperson_txt.Clear();
                addresspatient_txt.Clear();
                telpatient_txt.Clear();
                celpatient_txt.Clear();
                tworkpatient_txt.Clear();
                insurancepatient_txt.Text = "";
                affiliatepatient_txt.Clear();
                namepatient_txt.Focus();
                c.valor = "";
                //Borrar los datos del diagnostico de la ventana
                tmed_cb.Text = "";
                tmedcom_txt.Clear();
                mica_cb.Text = "";
                micacom_txt.Clear();
                ps_cb.Text = "";
                diab_cb.Text = "";
                hep_cb.Text = "";
                hepcom_txt.Clear();
                pr_cb.Text = "";
                pe_cb.Text = "";
                pecom_txt.Clear();
                pa_cb.Text = "";
                pacom_txt.Clear();
                hemo_cb.Text = "";
                aler_cb.Text = "";
                alercom_txt.Clear();

                try
                {
                    string query2 = "INSERT INTO [patient](idperson) VALUES('empty');";
                    string query3 = "DELETE FROM [patient] WHERE name is null";
                    c.command3(query3);
                    c.command3(query2);
                    string query4 = "Select idpatient from [patient] where idpatient = (select max(idpatient) from [patient])";
                    string condition = "idpatient";
                    c.last_id(idpatient_txt, query4, condition);
                    idpatient_md_txt.Text = idpatient_txt.Text;
                }
                catch
                {

                }
            }
            else
            {

            }
        }

        private void updatepatient_btn_Click(object sender, EventArgs e)
        {

            DBManager c = new DBManager();
            DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
            string query = "UPDATE patient set name = '" + namepatient_txt.Text + "', sex = '" + sexpatient_cb.Text + "', bday = '" + bdaypatient_dtp.Text + "', idperson = '" + idperson_txt.Text + "', address = '" + addresspatient_txt.Text + "', tel = '" + telpatient_txt.Text + "', cel = '" + celpatient_txt.Text + "', telwork = '" + tworkpatient_txt.Text + "', insurance = '" + insurancepatient_txt.Text + "', affiliate = '" + affiliatepatient_txt.Text + "' WHERE idpatient = '" + idpatient_txt.Text + "'";
            c.command3(query);
            string query2 = "UPDATE medicald set tmed = '" + tmed_cb.Text + "', tmedcom = '" + tmedcom_txt.Text + "', mica = '" + mica_cb.Text + "', micacom = '" + micacom_txt.Text + "', ps = '" + ps_cb.Text + "', diab = '" + diab_cb.Text + "', hep = '" + hep_cb.Text + "', hepcom = '" + hepcom_txt.Text + "', pr = '" + pr_cb.Text + "', pe = '" + pe_cb.Text + "', pecom = '" + pecom_txt.Text + "', pa = '" + pa_cb.Text + "', pacom = '" + pacom_txt.Text + "', hemo = '" + hemo_cb.Text + "', aler = '" + aler_cb.Text + "', alercom = '" + alercom_txt.Text + "' WHERE idpatient = '" + idpatient_md_txt.Text + "';";
            c.command(query2);

                if (c.valor == "si")
                {
                    Close();
                }
            }
                else if (result == DialogResult.No)
                {

                }
        }

        private void clearform_btn_Click(object sender, EventArgs e)
        {
            namepatient_txt.Clear();
            sexpatient_cb.Text = "";
            idperson_txt.Clear();
            addresspatient_txt.Clear();
            telpatient_txt.Clear();
            celpatient_txt.Clear();
            tworkpatient_txt.Clear();
            insurancepatient_txt.Text = "";
            affiliatepatient_txt.Clear();
            namepatient_txt.Focus();
        }

        private void delatepatient_btn_Click(object sender, EventArgs e)
        {
         

            DBManager c = new DBManager();
            DialogResult result = MessageBox.Show("Seguro que desea borra este paciente?, Al borrar el paciente solo se inhabilita la opción de agregarle procedimientos o citas, pero este seguirá apareciendo en los registros necesarios.", "Borrar datos del Paciente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
             string query = "DELETE FROM patient WHERE idpatient = '" + idpatient_txt.Text + "'";
             c.command(query);
            if (c.valor == "si")
            {
                this.Close();
            }
                }
                else if (result == DialogResult.No)
                {

                }

            //DialogResult result = MessageBox.Show("Seguro que desea eliminar este Paciente?", "Eliminar paciente", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            //{
            //    SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //    try
            //    {
            //        cnx.Open();
            //        string comando = "DELETE FROM patient WHERE id = '" + idpatient_txt.Text + "'";
            //        SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
            //        if (insertion.ExecuteNonQuery() > 0)
            //        {
            //            MessageBox.Show("Se ha eliminado!");
            //            Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Algo fue mal");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error");
            //    }
                
            //}
            //else if (result == DialogResult.No)
            //{
            //}
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
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
                DBManager c = new DBManager();
                //string query = "select * from medicald where idpatient = '" + idpatient_md_txt.Text + "'";
                //c.command3(query);
                //MessageBox.Show("valor de valor " + c.valor);
                try
                {
                    string query2 = "UPDATE medicald Set tmed = '" + tmed_cb.Text + "', tmedcom = '" + tmedcom_txt.Text + "', mica = '" + mica_cb.Text + "', micacom = '" + micacom_txt.Text + "', ps = '" + ps_cb.Text + "', diab = '" + diab_cb.Text + "', hep = '" + hep_cb.Text + "', hepcom = '" + hepcom_txt.Text + "', pr = '" + pr_cb.Text + "', pe = '" + pe_cb.Text + "', pecom = '" + pecom_txt.Text + "', pa = '" + pa_cb.Text + "', pacom = '" + pacom_txt.Text + "', hemo = '" + hemo_cb.Text + "', aler = '" + aler_cb.Text + "', alercom = '" + alercom_txt.Text + "' WHERE idpatient = '" + idpatient_md_txt.Text + "';";
                    c.command(query2);
                    //c.valor = "no";
                }
                catch
                {
                    string query3 = "INSERT INTO medicald(idpatient, tmed, tmedcom, mica, micacom, ps, diab, hep, hepcom, pr, pe, pecom, pa, pacom, hemo, aler, alercom) VALUES ('" + idpatient_md_txt.Text + "', '" + tmed_cb.Text + "', '" + tmedcom_txt.Text + "', '" + mica_cb.Text + "', '" + micacom_txt.Text + "', '" + ps_cb.Text + "', '" + diab_cb.Text + "', '" + hep_cb.Text + "', '" + hepcom_txt.Text + "', '" + pr_cb.Text + "', '" + pe_cb.Text + "', '" + pecom_txt.Text + "', '" + pa_cb.Text + "', '" + pacom_txt.Text + "', '" + hemo_cb.Text + "', '" + aler_cb.Text + "', '" + alercom_txt.Text + "')";
                    c.command(query3);
                }
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
            DBManager c = new DBManager();
            string query = "select idhistory as ID, diente as Diente, activity as Actividad, abono as Abono, date as Fecha from patienthistory where idpatient like '%" + searchhistory_txt.Text + "%'";
            c.load_dgv(patienthistory, query);
        }

        private void insurancepatient_txt_Click(object sender, EventArgs e)
        {
            
        }

        private void insurancepatient_txt_MouseClick(object sender, MouseEventArgs e)
        {
            if(insurancepatient_txt.Items.Count <= 0)
            {
                string query3 = "Select idinsurance, nameinsurance from insurances";
                string item = "nameinsurance";
                c.fill_CB(insurancepatient_txt, query3, item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmed_cb.Text = "No";
            mica_cb.Text = "No";
            ps_cb.Text = "No";
            diab_cb.Text = "No";
            hep_cb.Text = "No";
            pr_cb.Text = "No";
            pe_cb.Text = "No";
            pa_cb.Text = "No";
            hemo_cb.Text = "No";
            aler_cb.Text = "No";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // Form f = new AddPatient();
            //f.ShowInTaskbar = false;
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
    }
}
