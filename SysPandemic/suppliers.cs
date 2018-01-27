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
    
    public partial class suppliers : Form
    {
        DBManager c = new DBManager();
        public suppliers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void suppliers_Load(object sender, EventArgs e)
        {
            string query = "select idprovider as ID, nameprovider as Nombre, addressprovider as Direccion, phoneprovider as Telefono, email as 'E-mail' from [provider]";
            c.load_dgv(providers_dgv, query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select idprovider as ID, nameprovider as Nombre, addressprovider as Direccion, phoneprovider as Telefono, email as 'E-mail' from [provider] where nameprovider like '%" + searchprovider.Text + "%'";
            c.load_dgv(providers_dgv, query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerprovider frm = new managerprovider();
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            managerprovider frm = new managerprovider();
            DataGridViewRow act = providers_dgv.Rows[e.RowIndex];
            frm.idprovider_txt.Text = act.Cells["ID"].Value.ToString();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void refreshp_Click(object sender, EventArgs e)
        {
            string query = "select idprovider as ID, nameprovider as Nombre, addressprovider as Direccion, phoneprovider as Telefono, email as 'E-mail' from [provider]";
            c.load_dgv(providers_dgv, query);
        }
        public void refreshproviders()
        {
            string query = "select idprovider as ID, nameprovider as Nombre, addressprovider as Direccion, phoneprovider as Telefono, email as 'E-mail' from [provider]";
            c.load_dgv(providers_dgv, query);
        }

        private void suppliers_Activated(object sender, EventArgs e)
        {
            string query = "select idprovider as ID, nameprovider as Nombre, addressprovider as Direccion, phoneprovider as Telefono, email as 'E-mail' from [provider]";
            c.load_dgv(providers_dgv, query);
        }
    }
}
