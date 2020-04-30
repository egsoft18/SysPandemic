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
    public partial class seepwi : Form
    {
        public seepwi()
        {
            InitializeComponent();
        }

        private void seepwi_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        public void loaddgv()
        {
            string query = "Select id as ID, pinsurance as Proceso, tariff as Precio from detailsinsurance where idinsurance = 1004 ";
            DBManager c = new DBManager();
            c.load_dgv(dataGridView1, query);
        }
        private void addprocess_btn_Click(object sender, EventArgs e)
        {
            addpwi frm = new addpwi();
            frm.MdiParent = this.MdiParent;
            frm.updatepwi_btn.Hide();
            frm.deletepwi_btn.Hide();
            frm.Show();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addpwi frm = new addpwi();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.idprocess_txt.Text = act.Cells["ID"].Value.ToString();
            frm.process_txt.Text = act.Cells["Proceso"].Value.ToString();
            frm.priceprocess_txt.Text = act.Cells["Precio"].Value.ToString();
            frm.savepwi_btn.Hide();
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void searchprocess_txt_TextChanged(object sender, EventArgs e)
        {
           string query = "Select id as ID, pinsurance as Proceso, tariff as Precio from detailsinsurance where idinsurance = 0 and pinsurance like '%"+searchprocess_txt.Text+"%' ";
           DBManager c = new DBManager();
           c.load_dgv(dataGridView1, query);
        }

        private void seepwi_Activated(object sender, EventArgs e)
        {
            loaddgv();
        }
    }
}
