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

        }

        private void printpatient_btn_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "Select * from patient where id = '" + idpatient_txt.Text + "'";
                ad = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                ds.Tables[0].TableName = "Empleados";
                ds.WriteXml(@"C:\SysPandemic\xml\patient.xml");
                //MessageBox.Show("Done");
                reportview rv = new reportview("patient.rpt");
                rv.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void savepatient_txt_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string comando = "INSERT INTO patient(name, bday, sex, idperson, address, tel, cel, telwork, insurance, affiliate) VALUES('" + namepatient_txt.Text + "', '" + bdaypatient_dtp.Text + "','" + sexpatient_cb.Text + "','" + idperson_txt.Text + "', '" + addresspatient_txt.Text + "', '" + telpatient_txt.Text + "', '" + celpatient_txt.Text + "', '" + tworkpatient_txt.Text + "', '" + insurancepatient_txt.Text + "', '" + affiliatepatient_txt.Text + "');";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void updatepatient_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string comando = "UPDATE patient set name = '" + namepatient_txt.Text + "', sex = '" + sexpatient_cb.Text + "', bday = '" + bdaypatient_dtp.Text + "', idperson = '" + idperson_txt.Text + "', address = '" + addresspatient_txt.Text + "', tel = '" + telpatient_txt.Text + "', cel = '" + celpatient_txt.Text + "', telwork = '" + tworkpatient_txt.Text + "', insurance = '" + insurancepatient_txt.Text + "', affiliate = '" + affiliatepatient_txt.Text + "' WHERE id = '" + idpatient_txt.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha actualizado!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo fallo!!!");
                    }
                }
                else if (result == DialogResult.No)
                {

                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

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
            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Paciente?", "Eliminar paciente", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                try
                {
                    cnx.Open();
                    string comando = "DELETE FROM patient WHERE id = '" + idpatient_txt.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha eliminado!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo fue mal");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
    }
}
