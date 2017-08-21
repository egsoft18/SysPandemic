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
    public partial class addsubprocedure : Form
    {
        public addsubprocedure()
        {
            InitializeComponent();
            subprocedure_txt.Focus();
           
        }

        private void addsubprocedure_Load(object sender, EventArgs e)
        {
            //cargarDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string comando = "INSERT INTO subprocedure(idprocedure, subprocedure, date) VALUES('" + idsubprocedure_txt.Text + "', '" + subprocedure_txt.Text + "','" + spdate.Text + "');";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente");
                    subprocedure_txt.Text = "";
                    cargarDGV();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            
        }
        public void cargarDGV()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string idpro = idsubprocedure_txt.Text;
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idprocedure as ProcedureNo, subprocedure as SubProceso, date as Fecha from subprocedure where idprocedure = '" + idpro + "'", cnx);
                DataTable tabla = new DataTable("Sub-Procedimientos");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar este avance del procedimiento?", "Eliminar avance del procedimiento", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
                    string value = act.Cells["ID"].Value.ToString();
                    SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                    cnx.Open();
                    string comando = "DELETE FROM subprocedure WHERE id = '" + value + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha eliminado!");
                        cargarDGV();
                    }
                    else
                    {
                        MessageBox.Show("Algo fue mal");
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

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Facturar?", "Facturar procedimiento", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                string com = "INSERT INTO bills(idprocedure, procedure, namep, named, realprice, iscoverage, totalpay, datebill) VALUES('" + idsubprocedure_txt.Text + "', '" + sprocedure_txt.Text + "', '" + spnamepatient_txt.Text + "','" + spnamedoctor_txt.Text + "','" + sprealpay_txt.Text + "', '" + spiscoverage_txt.Text + "', '" + sppricepay_txt.Text + "', '" + todaydtp.Text + "');";
                SQLiteCommand insertion = new SQLiteCommand(com, cnx);

                String status = "PAGADO";
                string comando = "UPDATE procedure set statuspay = '" + status + "' WHERE idprocedure = '" + idsubprocedure_txt.Text + "'";
                SQLiteCommand insertion2 = new SQLiteCommand(comando, cnx);
                if (insertion2.ExecuteNonQuery() > 0 && insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Hecho");
                }

                SQLiteDataAdapter ad;
                SQLiteDataAdapter ad2;
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                SQLiteCommand cmd = cnx.CreateCommand();
                SQLiteCommand cmd2 = cnx.CreateCommand();
                cmd.CommandText = "Select * from procedure where idprocedure = '" + idsubprocedure_txt.Text + "'";
                cmd2.CommandText = "Select * from patient where name = '" + spnamepatient_txt.Text + "'";
                ad = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                ds.Tables[0].TableName = "Procedimiento";
                ds.WriteXml(@"C:\SysPandemic\xml\procedure.xml");
                ad2 = new SQLiteDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                ad2.Fill(dt2);
                ds2.Tables.Add(dt2);
                ds2.Tables[0].TableName = "infopaciente";
                ds2.WriteXml(@"C:\SysPandemic\xml\infopatient.xml");

                SQLiteDataAdapter ad3;
                DataTable dt3 = new DataTable();
                SQLiteCommand cmd3 = cnx.CreateCommand();
                cmd3.CommandText = "Select * from bills where idprocedure = '" + idsubprocedure_txt.Text + "'";
                ad3 = new SQLiteDataAdapter(cmd3);
                DataSet ds3 = new DataSet();
                ad3.Fill(dt3);
                ds3.Tables.Add(dt3);
                ds3.Tables[0].TableName = "date";
                ds3.WriteXml(@"C:\SysPandemic\xml\datebill.xml");
              
              
                reportview rv = new reportview("bill.rpt");
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
        


        private void printpurchase_btn_Click(object sender, EventArgs e)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                    SQLiteDataAdapter ad;
                    SQLiteDataAdapter ad2;
                    DataTable dt = new DataTable();
                    DataTable dt2 = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    SQLiteCommand cmd2 = cnx.CreateCommand();
                    cmd.CommandText = "Select * from procedure where idprocedure = '" + idsubprocedure_txt.Text + "'";
                    cmd2.CommandText = "Select * from patient where name = '" + spnamepatient_txt.Text + "'";
                    ad = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    ad.Fill(dt);
                    ds.Tables.Add(dt);
                    ds.Tables[0].TableName = "Procedimiento";
                    ds.WriteXml(@"C:\SysPandemic\xml\procedure.xml");
                    ad2 = new SQLiteDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    ad2.Fill(dt2);
                    ds2.Tables.Add(dt2);
                    ds2.Tables[0].TableName = "infopaciente";
                    ds2.WriteXml(@"C:\SysPandemic\xml\infopatient.xml");

                    SQLiteDataAdapter ad3;
                    DataTable dt3 = new DataTable();
                    SQLiteCommand cmd3 = cnx.CreateCommand();
                    cmd3.CommandText = "Select * from bills where idprocedure = '" + idsubprocedure_txt.Text + "'";
                    ad3 = new SQLiteDataAdapter(cmd3);
                    DataSet ds3 = new DataSet();
                    ad3.Fill(dt3);
                    ds3.Tables.Add(dt3);
                    ds3.Tables[0].TableName = "date";
                    ds3.WriteXml(@"C:\SysPandemic\xml\datebill.xml");


                    reportview rv = new reportview("bill.rpt");
                    rv.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void printprocedure_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter ad;
                DataTable dt = new DataTable();
                SQLiteCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "Select * from procedure where idprocedure = '" + idsubprocedure_txt.Text + "'";
                ad = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                ds.Tables[0].TableName = "Procedimiento";
                ds.WriteXml(@"C:\SysPandemic\xml\procedure.xml");

                SQLiteDataAdapter ad2;
                DataTable dt2 = new DataTable();
                SQLiteCommand cmd2 = cnx.CreateCommand();
                cmd2.CommandText = "Select * from subprocedure where idprocedure = '" + idsubprocedure_txt.Text + "'";
                ad2 = new SQLiteDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                ad2.Fill(dt2);
                ds2.Tables.Add(dt2);

                if (dt2.Rows.Count <= 0)
                {
                    MessageBox.Show("Se debe de agregar al menos un avance para imprimir.");
                }
                else
                {
                    ds2.Tables[0].TableName = "subProcedimiento";
                    ds2.WriteXml(@"C:\SysPandemic\xml\subprocedure.xml");
                    //MessageBox.Show("Done");
                reportview rv = new reportview("reportprocedure.rpt");
                rv.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }
    }
}
