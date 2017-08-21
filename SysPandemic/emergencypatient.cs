using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPandemic
{
    public partial class emergencypatient : Form
    {
        public emergencypatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtcober.Text))
                {
                    double realpay = Convert.ToDouble(txtprecio.Text);
                    txtpreap.Text = Convert.ToString(realpay);
                    txtcober.Text = "0";
                }
                else
                {
                    double realpay = Convert.ToDouble(txtprecio.Text);
                    double iscoverage = Convert.ToDouble(txtcober.Text);
                    double pricepay;
                    pricepay = realpay - iscoverage;
                    txtpreap.Text = Convert.ToString(pricepay);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha insertado un o varios valores invalidos: favor revise!", "Error");

            }
        }

        private void btncan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string status = "NO PAGADO";

                string comando = "INSERT INTO emerpat(name,sex,address,tel, procedure, realprice, iscoverage, pricepay, time, statuspay) VALUES('" + txtname.Text + "','" + cmbsex.Text + "','" + txtaddres.Text + "','" + txttel.Text + "','" + txtprocedure.Text + "','" + txtprecio.Text + "','" + txtcober.Text + "','" + txtpreap.Text + "','"+dtptime.Text+"', '" + status + "')";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego satisfactoriamente");
                    txtname.Clear();
                    cmbsex.Text = "";
                    txtaddres.Clear();
                    txttel.Clear();
                    txtprecio.Clear();
                    txtcober.Clear();
                    txtpreap.Clear();
                }
                else
                {
                    MessageBox.Show("Algo va mal");
                }
                
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtaddres.Clear();
            txtcober.Clear();
            txtname.Clear();
            txtpreap.Clear();
            txtprecio.Clear();
            txtprocedure.Clear();
            txttel.Clear();
            cmbsex.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updatepa_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente Ambulante", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string status = "NO PAGADO";
                    string comando = "UPDATE emerpat set name = '" + txtname.Text + "', sex = '" + cmbsex.Text + "', address = '" + txtaddres.Text + "', tel = '" + txttel.Text + "', procedure = '" + txtprocedure.Text + "', realprice = '" + txtprecio.Text + "', iscoverage = '" + txtcober.Text + "', pricepay = '" + txtpreap.Text + "', time = '" + dtptime.Text + "', statuspay = '" + status + "'";
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

        private void deletepa_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Paciente Ambulante?", "Eliminar Paciente Ambulante", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                try
                {
                    cnx.Open();
                    string comando = "DELETE FROM emerpat WHERE idep = '" + idpaemer_txt.Text + "'";
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
        }

        private void billpa_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Facturar?", "Facturar procedimiento", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string am = "Ambulante";
                    string com = "INSERT INTO bills(idprocedure, procedure, namep, named, realprice, iscoverage, totalpay, datebill) VALUES('" + am + "', '" + txtprocedure.Text + "', '" + txtname.Text + "','" + am + "','" + txtprecio.Text + "', '" + txtcober.Text + "', '" + txtpreap.Text + "', '" + datetoday.Text + "');";
                    SQLiteCommand insertion = new SQLiteCommand(com, cnx);

                    String status = "PAGADO";
                    string comando = "UPDATE emerpat set statuspay = '" + status + "' WHERE idep = '" + idpaemer_txt.Text + "'";
                    SQLiteCommand insertion2 = new SQLiteCommand(comando, cnx);

                    if (insertion2.ExecuteNonQuery() > 0 && insertion.ExecuteNonQuery() > 0)
                    {
                    }

                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select * from emerpat where idep = '" + idpaemer_txt.Text + "'";
                    ad = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    ad.Fill(dt);
                    ds.Tables.Add(dt);
                    ds.Tables[0].TableName = "FacturaAmbulante";
                    ds.WriteXml(@"C:\SysPandemic\xml\apatientebill.xml");
                    //MessageBox.Show("Done");
                    reportview rv = new reportview("billep.rpt");
                    rv.Show();
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
        public void facturarep()
        {
            
        }

        private void seebill_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter ad;
                DataTable dt = new DataTable();
                SQLiteCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "Select * from emerpat where idep = '" + idpaemer_txt.Text + "'";
                ad = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                ds.Tables[0].TableName = "FacturaAmbulante";
                ds.WriteXml(@"C:\SysPandemic\xml\apatientebill.xml");
                //MessageBox.Show("Done");
                reportview rv = new reportview("billep.rpt");
                rv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
