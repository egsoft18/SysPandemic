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
    public partial class providerselect : Form
    {
        DBManager c = new DBManager();
        public string idp;
        public string namep;
        public providerselect()
        {
            InitializeComponent();
        }

        private void providerselect_Load(object sender, EventArgs e)
        {
            string query = "select idprovider as ID, nameprovider as 'Nombre' from provider";
            c.load_dgv(dataGridView1, query);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            enterinvoice f = new enterinvoice();
                f.idprovider.Text = act.Cells["ID"].Value.ToString();
                f.nameprovider.Text = act.Cells["Nombre"].Value.ToString();
            //getdate c = new getdate();
            //c.getdatep(id, name, frm.idprovider, frm.nameprovider);
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Close();
           

        }
    }
}
