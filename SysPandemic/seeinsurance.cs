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
    public partial class seeinsurance : Form
    {
        public seeinsurance()
        {
            InitializeComponent();
        }

        private void seeinsurance_Load(object sender, EventArgs e)
        {
            DGVload();
        }
        public void DGVload()
        {
            string query = "Select idinsurance as ID, nameinsurance as Seguro, telinsurance as Telefono, emailinsurance as Correo, contractinsurance as Conrato, pssinsurance as PSS from insurances";
            DBManager c = new DBManager();
            c.load_dgv(dataGridView1,query);



            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idinsurance as ID, nameinsurance as Seguro, telinsurance as Telefono, emailinsurance as Correo, contractinsurance as Conrato, pssinsurance as PSS from insurances", cnx);
            //    DataTable tabla = new DataTable("Seguros");
            //    adac.Fill(tabla);
            //    dataGridView1.DataSource = tabla;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DGVload();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscar();

        }
        private void buscar()
        {
            string query = "Select idinsurance as ID, nameinsurance as Seguro, telinsurance as Telefono, emailinsurance as Correo, contractinsurance as Conrato, pssinsurance as PSS from insurances where nameinsurance like '%" + search_txt.Text + "%'";
            DBManager c = new DBManager();
            c.load_dgv(dataGridView1, query);


            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idinsurance as ID, nameinsurance as Seguro, telinsurance as Telefono, emailinsurance as Correo, contractinsurance as Conrato, pssinsurance as PSS from insurances where nameinsurance like '%" + search_txt.Text + "%'", cnx);
            //    DataTable tabla = new DataTable("Seguros");
            //    adac.Fill(tabla);
            //    dataGridView1.DataSource = tabla;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void searchinsurance_btn_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                insuranceadmi frm = new insuranceadmi();
                DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
                frm.pidinsurance_txt.Text = act.Cells["ID"].Value.ToString();
                frm.pnameinsurance_txt.Text = act.Cells["Seguro"].Value.ToString();
                frm.ptelinsurance_txt.Text = act.Cells["Telefono"].Value.ToString();
                frm.pmailinsurance_txt.Text = act.Cells["Correo"].Value.ToString();
                frm.pcontractinsurance_txt.Text = act.Cells["Conrato"].Value.ToString();
                frm.ppssinsurance_txt.Text = act.Cells["PSS"].Value.ToString();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
