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
           
        }

        private void addsubprocedure_Load(object sender, EventArgs e)
        {
            cargarDGV();
            DBManager c = new DBManager();
            string query = "SELECT sum(entry) as qty FROM [SysPandemic].[dbo].[transaction] where ref = '" + idsubprocedure_txt.Text + "'";
            string condition = "qty";
            c.fill_txt(nowpay_txt, query, condition);

            if (string.IsNullOrEmpty(nowpay_txt.Text))
            {
                decimal ppay = Convert.ToDecimal(sppricepay_txt.Text);
                balancepay_txt.Text = Convert.ToString(ppay);
            }
            else
            {
                decimal ppay = Convert.ToDecimal(sppricepay_txt.Text);
                decimal nowpay = Convert.ToDecimal(nowpay_txt.Text);
                balancepay_txt.Text = Convert.ToString(ppay - nowpay);
            }
            if (string.IsNullOrEmpty(idsubprocedure_txt.Text))
            {

            }
            else
            {
                string query5 = "select tooth from [procedure] where idprocedure = '" + idsubprocedure_txt.Text + "'";
                c.fill_txt(stooth_txt, query5, "tooth");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        public void cargarDGV()
        {
            DBManager c = new DBManager();
            string query = "Select id as ID, idprocedure as ProcedureNo, subprocedure as SubProceso, tariff as Tarifa, coverage as Covertura, difference as Diferencia from subprocedure where idprocedure = '" + idsubprocedure_txt.Text + "'";
            c.load_dgv(dataGridView1, query);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void loadbill()
        {
            cargarDGV();
            DBManager c = new DBManager();
            string query = "SELECT sum(entry) as qty FROM [SysPandemic].[dbo].[transaction] where ref = '" + idsubprocedure_txt.Text + "'";
            string condition = "qty";
            c.fill_txt(nowpay_txt, query, condition);

            if (string.IsNullOrEmpty(nowpay_txt.Text))
            {
                decimal ppay = Convert.ToDecimal(sppricepay_txt.Text);
                balancepay_txt.Text = Convert.ToString(ppay);
            }
            else
            {
                decimal ppay = Convert.ToDecimal(sppricepay_txt.Text);
                decimal nowpay = Convert.ToDecimal(nowpay_txt.Text);
                balancepay_txt.Text = Convert.ToString(ppay - nowpay);
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
            MessageBox.Show("Sin accion asignada.");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addpay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(typepay.Text))
            {
                MessageBox.Show("Debe de elegir un metodo de pago.", "Error");
            }
            else
            {
                if (string.IsNullOrEmpty(qtypay.Text))
                {
                    MessageBox.Show("Debe de elegir una cantidad de pago.", "Error");
                }
                else
                {
                    DBManager c = new DBManager();
                    string query = "INSERT INTO [transaction](ref, madebytran, reasontran, datetran, origin, entry, expenses) values('" + idsubprocedure_txt.Text + "', '" + spnamepatient_txt.Text + "', '" + sprocedure_txt.Text + "', '" + datepay.Text + "', '" + typepay.Text + "', '" + qtypay.Text + "', '0')";
                    decimal ppay = Convert.ToDecimal(sppricepay_txt.Text);

                    decimal qty = Convert.ToDecimal(qtypay.Text);

                    if (string.IsNullOrEmpty(nowpay_txt.Text))
                    {
                        if (ppay >= qty)
                        {
                            c.command(query);

                            //Insertar en la tabla del historico del paciente
                            string hquery = "insert into patienthistory(idpatient, tooth, activity, qtypay, date) values('" + sidpatient.Text + "', '" + stooth_txt.Text + "', '" + sactivity_txt.Text + "', '" + qtypay.Text + "', '" + datepay.Text + "')";
                            c.command3(hquery);

                            loadbill();
                            string query2 = "Select top 1 * from [transaction] order by idtransactions desc";

                            string tablename = "entrybill";
                            string xml = "entrybill.xml";
                            string report = "entrybill.rpt";
                            c.printreport(query2, tablename, xml, report);
                        }
                        else
                        {
                            MessageBox.Show("El monto ha abonar mas lo ya abonado sobrepasa el precio del procedimiento, favor verifique y reintente");
                        }
                    }
                    else
                    {
                        decimal nowpay = Convert.ToDecimal(nowpay_txt.Text);
                        if (ppay > nowpay)
                        {
                            if (ppay >= (nowpay + qty))
                            {
                                c.command(query);
                                loadbill();
                                
                                //Insertar en la tabla del historico del paciente
                                string hquery = "insert into patienthistory(idpatient, tooth, activity, qtypay, date) values('" + sidpatient.Text + "', '" + stooth_txt.Text + "', '" + sactivity_txt.Text + "', '" + qtypay.Text + "', '" + datepay.Text + "')";
                                c.command3(hquery);

                                string query3 = "Select top 1 * from [transaction] order by idtransactions desc";

                                string tablename = "entrybill";
                                string xml = "entrybill.xml";
                                string report = "entrybill.rpt";
                                c.printreport(query3, tablename, xml, report);
                            }
                            else
                            {
                                MessageBox.Show("El monto ha abonar mas lo ya abonado sobrepasa el precio del procedimiento, favor verifique y reintente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("NO puede abonar, debido a que el procedimiento ya esta pagado.");
                        }
                    }
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
