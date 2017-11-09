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
    public partial class searchpatientpre : Form
    {
        public searchpatientpre()
        {
            InitializeComponent();
        }

        private void searchpatientpre_Load(object sender, EventArgs e)
        {
            string query = "select idpatient as ID, name as Nombre, bday as FechaNac from patient";
            DBManager c = new DBManager();
            c.load_dgv(dataGridView1, query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select idpatient as ID, name as Nombre, bday as FechaNac from patient where name like '%"+ namesearch.Text+ "%'";
            DBManager c = new DBManager();
            c.load_dgv(dataGridView1, query);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            prescription frm = new prescription();
            try
            {
                DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
                frm.patientpre.Text = act.Cells["Nombre"].Value.ToString();
                frm.bdaypre.Text = act.Cells["FechaNac"].Value.ToString();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se consiguio lo querido", "Error");
            }
        }
    }
}
