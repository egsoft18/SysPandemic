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
            if (transall.Checked == true)
            {
                if (rankall.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select * from [transaction]";
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select * from [transaction] where origin = '" + paytype.Text + "'";
                    }
                }
                else if (rankdate.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select* from [transaction] where datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select * from [transaction] where origin = '" + paytype.Text + "' and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                    }
                }

            }
            else if (transentry.Checked == true)
            {
                if (rankall.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select * from [transaction] where entry > 0";
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select * from [transaction] where entry > 0 and origin = '" + paytype.Text + "'";
                    }
                }
                else if (rankdate.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select * from [transaction] where entry > 0 and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select * from [transaction] where entry > 0 and origin = '" + paytype.Text + "' and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                    }
                }
            }
            else if (transout.Checked == true)
            {
                if (rankall.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select * from [transaction] where expenses > 0";
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select * from [transaction] where expenses > 0 and origin like '" + paytype.Text + "'";

                    }
                }
                else if (rankdate.Checked == true)
                {
                    if (paytype.Text == "Todos")
                    {
                        string query = "select * from [transaction] where expenses > 0 and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                    }
                    else if (paytype.Text != "Todos")
                    {
                        string query = "select * from [transaction] where expenses > 0 and origin like '" + paytype.Text + "' and datetran between '" + datestart.Text + "' and '" + dateend.Text + "'";
                    }
                }
            }
            
        }
    }
}
