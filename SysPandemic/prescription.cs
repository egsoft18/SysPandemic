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
                    dataGridView1.Rows.Add(m, medicine.Text, use.Text, time.Text, patientpre.Text, bdaypre.Text, today.Text);
                    medicine.Clear();
                    use.Clear();
                    time.Clear();
                    medicine.Focus();

                    //DateTime nacimiento = new DateTime(bdaypre.long); //Fecha de nacimiento
                    //int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
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

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void printpre_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(patientpre.Text, bdaypre.Text, today.Text);


            DataTable dT = GetDataTableFromDGV(dataGridView1);
            DataSet dS = new DataSet();
            dS.Tables.Add(dT);
            dS.Tables[0].TableName = "prescription";
            dS.WriteXml(@"C:\SysPandemic server\xml\prescription.xml");

            //DataTable dT2 = GetDataTableFromDGV(dataGridView2);
            //DataSet dS2 = new DataSet();
            //dS2.Tables.Add(dT2);
            //dS2.Tables[0].TableName = "prescriptioninfo";
            //dS2.WriteXml(@"C:\SysPandemic server\xml\prescriptioninfo.xml");
            string rpt = "prescriptionr2.rpt";
            reportview rv = new reportview(rpt);
            rv.Show();

        }
    }
}
