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
    public partial class prescription : Form
    {
        int m = 0;
        public prescription()
        {
            InitializeComponent();
        }

        private void searchpatient_Click(object sender, EventArgs e)
        {
            searchpatientpre frm = new searchpatientpre();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }

        private void addmedicine_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (patientpre.Text == "" || medicine.Text == "" || use.Text == "" || time.Text == "")
                {
                    MessageBox.Show("No puede ser agregado, pues faltan informaciones. TODOS LOS CAMPOS SON OBLIGATORIOS.");
                }
                else
                {
                    m = m + 1;
                    dataGridView1.Rows.Add(m, medicine.Text, use.Text, time.Text);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un problema interno");
            }
                
        }

        private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
        }
    }
}
