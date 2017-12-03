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
    public partial class seeinvoice : Form
    {
        DBManager c = new DBManager();
        public seeinvoice()
        {
            InitializeComponent();
        }

        private void seeinvoice_Load(object sender, EventArgs e)
        {
            provider_rbtn.PerformClick();


            string query = "select idtransactions as 'ID', ref as 'Referencia', madebytran as 'De', reasontran as 'Razon', datetran as 'Fecha', origin as 'Metodo',  expenses as 'Monto' from [transaction] where ref like 'F-%'";
            c.load_dgv(dataGridView1, query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               if (provider_rbtn.Checked){
                string query = "select idtransactions as 'ID', ref as 'Referencia', madebytran as 'De', reasontran as 'Razon', datetran as 'Fecha', origin as 'Metodo',  expenses as 'Monto' from [transaction] where ref like 'F-%' and madebytran like '%"+ searchbill.Text+"%'";
                c.load_dgv(dataGridView1, query);
            } 
               else if (reason_rbtn.Checked)
            {
                string query = "select idtransactions as 'ID', ref as 'Referencia', madebytran as 'De', reasontran as 'Razon', datetran as 'Fecha', origin as 'Metodo',  expenses as 'Monto' from [transaction] where ref like 'F-%' and reasontran like '%" + searchbill.Text + "%'";
                c.load_dgv(dataGridView1, query);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select idtransactions as 'ID', ref as 'Referencia', madebytran as 'De', reasontran as 'Razon', datetran as 'Fecha', origin as 'Metodo',  expenses as 'Monto' from [transaction] where ref like 'F-%'";
            c.load_dgv(dataGridView1, query);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enterinvoice frm = new enterinvoice();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.idonsys.Text = act.Cells["ID"].Value.ToString();
            frm.datebill.Text = act.Cells["Fecha"].Value.ToString();
            frm.paymeth.Text = act.Cells["Metodo"].Value.ToString();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
