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
    public partial class adddoctor : Form
    {
        public adddoctor()
        {
            InitializeComponent();
            
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void delatedoctor_btn_Click(object sender, EventArgs e)
        {
            DBManager c = new DBManager();
            string query = "DELETE FROM staff WHERE idstaff = '" + iddoctor_txt.Text + "'";
            c.command(query);
            this.Close();
        }

        private void updatedoctor_btn_Click(object sender, EventArgs e)
        {
            string iddoctor = iddoctor_txt.Text;
            string namedoctor = namedoctor_txt.Text;
            string sexdoctor = sexdoctor_cb.Text;
            string idperson = idperson_txt.Text;
            string addressdoctor = addressdoctor_txt.Text;
            string teldoctor = teldoctor_txt.Text;
            string celdoctor = celdoctor_txt.Text;
            string salary = salary_txt.Text;
            string role = "Doctor";
            //string condition = "";

            DBManager c = new DBManager();

            c.update_doctor(iddoctor, namedoctor, sexdoctor, idperson, addressdoctor, teldoctor, celdoctor, role, salary);
            this.Close();
            
           
        }

        private void savedoctor_btn_Click(object sender, EventArgs e)
        {

            string namedoctor = namedoctor_txt.Text;
            string sexdoctor = sexdoctor_cb.Text;
            string idperson = idperson_txt.Text;
            string addressdoctor = addressdoctor_txt.Text;
            string teldoctor = teldoctor_txt.Text;
            string celdoctor = celdoctor_txt.Text;
            string salary = salary_txt.Text;
            string role = "Doctor";
            string condition= "";

            DBManager c = new DBManager();
            c.add_staff(namedoctor, sexdoctor, idperson, addressdoctor, teldoctor, celdoctor, role, salary, condition);

            if (c.valor == "si")
            {
                namedoctor_txt.Text = "";
                sexdoctor_cb.Text = "";
                idperson_txt.Text = "";
                addressdoctor_txt.Text = "";
                teldoctor_txt.Text = "";
                celdoctor_txt.Text = "";
                salary_txt.Text = "";
            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            namedoctor_txt.Clear();
            sexdoctor_cb.Text = "";
            idperson_txt.Clear();
            addressdoctor_txt.Clear();
            teldoctor_txt.Clear();
            celdoctor_txt.Clear();
            namedoctor_txt.Focus();
        }

        private void adddoctor_Load(object sender, EventArgs e)
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
    }
}
