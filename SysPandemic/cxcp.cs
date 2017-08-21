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
    public partial class cxcp : Form
    {
        public cxcp()
        {
            InitializeComponent();
        }

        private void seecxc_rbtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (cxc_rbtn.Checked == true)
                {

                    if (allcxc_rbtn.Checked == true)
                    {
                        string comando = "Select * FROM procedure WHERE statuspay like 'NO PAGADO'";
                        SQLiteDataAdapter adac = new SQLiteDataAdapter(comando, cnx);
                        DataTable tabla = new DataTable("CxC-CP");
                        DataSet ds = new DataSet();
                        adac.Fill(tabla);
                        ds.Tables.Add(tabla);
                        if (tabla.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else { 
                        ds.Tables[0].TableName = "cxc-cp";
                        ds.WriteXml(@"C:\SysPandemic\xml\cxc-cp.xml");
                        //MessageBox.Show("Done");
                        reportview rv = new reportview("cxcpreport.rpt");
                        rv.Show();
                        }
                    }
                    else if (rankdate_rbtn.Checked == true)
                    {
                        string comando = "Select * FROM procedure WHERE statuspay like 'NO PAGADO' and dateprocedure between '"+startrank_dtp.Text+"' and '"+endrank_dtp.Text+"' ";
                        SQLiteDataAdapter adac = new SQLiteDataAdapter(comando, cnx);
                        DataTable tabla = new DataTable("CxC-CP");
                        DataSet ds = new DataSet();
                        adac.Fill(tabla);
                        ds.Tables.Add(tabla);
                        if (tabla.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        {
                            ds.Tables[0].TableName = "cxc-cp";
                            ds.WriteXml(@"C:\SysPandemic\xml\cxc-cp.xml");
                            //MessageBox.Show("Done");
                            reportview rv = new reportview("cxcpreport.rpt");
                            rv.Show();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Olvido seleccionar un rango.");
                    }
                }
                else if (cp_rbtn.Checked == true)
                {
                    if (allcxc_rbtn.Checked == true)
                    {
                        string comando = "Select * FROM procedure WHERE statuspay like 'PAGADO'";
                        SQLiteDataAdapter adac = new SQLiteDataAdapter(comando, cnx);
                        DataTable tabla = new DataTable("CxC-CP");
                        DataSet ds = new DataSet();
                        adac.Fill(tabla);
                        ds.Tables.Add(tabla);
                        if (tabla.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        {
                            ds.Tables[0].TableName = "cxc-cp";
                            ds.WriteXml(@"C:\SysPandemic\xml\cxc-cp.xml");
                            //MessageBox.Show("Done");
                            reportview rv = new reportview("cxcpreport.rpt");
                            rv.Show();
                        }
                    }
                    else if (rankdate_rbtn.Checked == true)
                    {
                        string comando = "Select * FROM procedure WHERE statuspay like 'PAGADO' and dateprocedure between '" + startrank_dtp.Text + "' and '" + endrank_dtp.Text + "' ";
                        SQLiteDataAdapter adac = new SQLiteDataAdapter(comando, cnx);
                        DataTable tabla = new DataTable("CxC-CP");
                        DataSet ds = new DataSet();
                        adac.Fill(tabla);
                        ds.Tables.Add(tabla);
                        if (tabla.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        {
                            ds.Tables[0].TableName = "cxc-cp";
                            ds.WriteXml(@"C:\SysPandemic\xml\cxc-cp.xml");
                            //MessageBox.Show("Done");
                            reportview rv = new reportview("cxcpreport.rpt");
                            rv.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Olvido seleccionar un rango.");
                    }
                }
                else
                {
                    MessageBox.Show("Olvido seleccionar una condicion.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
