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
    public partial class enterinvoice : Form
    {
        DBManager c = new DBManager();

        public enterinvoice()
        {
            InitializeComponent();
        }

        private void searchprovider_Click(object sender, EventArgs e)
        {
            providerselect frm = new providerselect();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void idonsys_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterinvoice_Load(object sender, EventArgs e)
        {
            if (idonsys.Text == "")
            {
                processinvoice.Text = "Insertar";
            }
            else
            {
                string query = "select idtransactions, ref, madebytran, reasontran, datetran, origin, expenses from [transaction] where idtransactions = '" + idonsys.Text + "'";
                c.fill_txt(nameprovider, query, "madebytran");
                c.fill_txt(nobill, query, "ref");
                c.fill_txt(reasonbill, query, "reasontran");
                c.fill_txt(qty, query, "expenses");


                nameprovider.Enabled = false;
                processinvoice.Text = "Actualizar";
                searchprovider.Hide();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void processinvoice_Click(object sender, EventArgs e)
        {
            if (idonsys.Text == "")
            {
                string query = "insert Into [transaction] (ref, madebytran, reasontran, datetran, origin, entry, expenses) values ('" + nobill.Text + "', '" + nameprovider.Text + "', '" + reasonbill.Text + "', '" + datebill.Text + "', '" + paymeth.Text + "', '0.00', '" + qty.Text + "')";
                c.command(query);
                this.Close();
            }
            else if (idonsys.Text != "")
            {
                string query = "update [transaction] set ref = '" + nobill.Text + "', madebytran = '" + nameprovider.Text + "', reasontran = '" + reasonbill.Text + "', datetran = '" + datebill.Text + "', origin = '" + paymeth.Text + "', expenses = '" + qty.Text + "'";
                c.command(query);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "delete from [transaction] where idtransactions = '" + idonsys.Text + "'";
            c.command(query);
        }
    }
    //public class getdate
    //{
    //    public void getdatep(string id, string name, TextBox idtxt, TextBox nametxt)
    //    {
    //        enterinvoice f = new enterinvoice();
    //        idtxt.Text = id;
    //        nametxt.Text = name;
    //    }
    //}
}
