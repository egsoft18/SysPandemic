using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPandemic
{
    public partial class closing : Form
    {
        public closing()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closing_Load(object sender, EventArgs e)
        {
            transall.PerformClick();
            rankall.PerformClick();
            paytype.Text = "Todos";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBManager c = new DBManager();
            string dt = "closing";
            string xml = "closing.xml";
            string rpt = "rclosing.rpt";
            if (transall.Checked == true)
            {
                if (rankall.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction]";
                        c.printreport(query, dt, xml, rpt); 
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where origin = '" + paytype.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                }
                else if (rankdate.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where origin = '" + paytype.Text + "' and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                }

            }
            else if (transentry.Checked == true)
            {
                if (rankall.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where entry > 0";
                        c.printreport(query, dt, xml, rpt);
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where entry > 0 and origin = '" + paytype.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                }
                else if (rankdate.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where entry > 0 and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where entry > 0 and origin = '" + paytype.Text + "' and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                }
            }
            else if (transout.Checked == true)
            {
                if (rankall.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where expenses > 0";
                        c.printreport(query, dt, xml, rpt);
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where expenses > 0 and origin like '" + paytype.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                }
                else if (rankdate.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where expenses > 0 and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, entry, expenses from [transaction] where expenses > 0 and origin like '" + paytype.Text + "' and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                        c.printreport(query, dt, xml, rpt);
                    }
                }
            }
            
        }
    }
}
