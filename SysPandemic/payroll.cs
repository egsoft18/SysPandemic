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
    public partial class payroll : Form
    {
        DBManager c = new DBManager();
        public payroll()
        {
            InitializeComponent();
            
        }

        private void payroll_Load(object sender, EventArgs e)
        {
            
        }

        private void payroll_Activated(object sender, EventArgs e)
        {
            string querry = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula, celstaff as Celular, rolestaff as Posicion from [staff] where rolestaff = '" + condition_txt.Text + "'";
            c.load_dgv(dataGridView1, querry);
        }

        private void payrollsearch_txt_TextChanged(object sender, EventArgs e)
        {
            string querry = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula, celstaff as Celular, rolestaff as Posicion from [staff] where rolestaff = '" + condition_txt.Text + "' and namestaff like '" + payrollsearch_txt.Text + "'";
            c.load_dgv(dataGridView1, querry);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            doctorpayroll frm = new doctorpayroll();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];

            frm.IdDoctorPR_txt.Text = act.Cells["ID"].Value.ToString();

            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
