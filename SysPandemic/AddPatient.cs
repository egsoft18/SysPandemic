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

namespace SysPandemic
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
            
        }

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
            
                string query = "Select idinsurance, nameinsurance from insurances";
                string item = "nameinsurance";
                DBManager c = new DBManager();
                c.fill_CB(insurancepatient_txt, query, item);

                idpatient_md_txt.Text = idpatient_txt.Text;
                namep_md_txt.Text = namepatient_txt.Text;
            
            
            
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
            string query = "Select * from patient where idpatient = '" + idpatient_txt.Text + "'";
            string tablename = "Empleados";
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
            
            
            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    string comando = "INSERT INTO patient(name, bday, sex, idperson, address, tel, cel, telwork, insurance, affiliate) VALUES('" + namepatient_txt.Text + "', '" + bdaypatient_dtp.Text + "','" + sexpatient_cb.Text + "','" + idperson_txt.Text + "', '" + addresspatient_txt.Text + "', '" + telpatient_txt.Text + "', '" + celpatient_txt.Text + "', '" + tworkpatient_txt.Text + "', '" + insurancepatient_txt.Text + "', '" + affiliatepatient_txt.Text + "');";
            //    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);

            //    if (insertion.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Se agrego correctamente");
            //        namepatient_txt.Clear();
            //        sexpatient_cb.Text = "";
            //        idperson_txt.Clear();
            //        addresspatient_txt.Clear();
            //        telpatient_txt.Clear();
            //        celpatient_txt.Clear();
            //        tworkpatient_txt.Clear();
            //        insurancepatient_txt.Text = "";
            //        affiliatepatient_txt.Clear();
            //        namepatient_txt.Focus();
                    
            //    }
            //}
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error");

            //    }
        }

        private void updatepatient_btn_Click(object sender, EventArgs e)
        {

            DBManager c = new DBManager();
            string query = "UPDATE patient set name = '" + namepatient_txt.Text + "', sex = '" + sexpatient_cb.Text + "', bday = '" + bdaypatient_dtp.Text + "', idperson = '" + idperson_txt.Text + "', address = '" + addresspatient_txt.Text + "', tel = '" + telpatient_txt.Text + "', cel = '" + celpatient_txt.Text + "', telwork = '" + tworkpatient_txt.Text + "', insurance = '" + insurancepatient_txt.Text + "', affiliate = '" + affiliatepatient_txt.Text + "' WHERE idpatient = '" + idpatient_txt.Text + "'";
            c.command(query);
            string query2 = "UPDATE medicald Set tmed = '" + tmed_cb.Text + "', tmedcom = '" + tmedcom_txt.Text + "', mica = '" + mica_cb.Text + "', micacom = '" + micacom_txt.Text + "', ps = '" + ps_cb.Text + "', diab = '" + diab_cb.Text + "', hep = '" + hep_cb.Text + "', hepcom = '" + hepcom_txt.Text + "', pr = '" + pr_cb.Text + "', pe = '" + pe_cb.Text + "', pecom = '" + pecom_txt.Text + "', pa = '" + pa_cb.Text + "', pacom = '" + pacom_txt.Text + "', hemo = '" + hemo_cb.Text + "', aler = '" + aler_cb.Text + "', alercom = '" + alercom_txt.Text + "' WHERE idpatient = '" + idpatient_md_txt.Text + "';";
            c.command3(query2);

            if (c.valor == "si")
            {
                Close();
                
            }
            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        string comando = "UPDATE patient set name = '" + namepatient_txt.Text + "', sex = '" + sexpatient_cb.Text + "', bday = '" + bdaypatient_dtp.Text + "', idperson = '" + idperson_txt.Text + "', address = '" + addresspatient_txt.Text + "', tel = '" + telpatient_txt.Text + "', cel = '" + celpatient_txt.Text + "', telwork = '" + tworkpatient_txt.Text + "', insurance = '" + insurancepatient_txt.Text + "', affiliate = '" + affiliatepatient_txt.Text + "' WHERE id = '" + idpatient_txt.Text + "'";
            //        SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
            //        if (insertion.ExecuteNonQuery() > 0)
            //        {
            //            MessageBox.Show("Se ha actualizado!");
            //            Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Algo fallo!!!");
            //        }
            //    }
            //    else if (result == DialogResult.No)
            //    {

            //    }
              
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");

            //}
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
             string query = "DELETE FROM patient WHERE idpatient = '" + idpatient_txt.Text + "'";
             c.command(query);
            if (c.valor == "si"){
                this.Close();
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
      
    }
}
