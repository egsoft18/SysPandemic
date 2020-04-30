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
    public partial class addinsurance : Form
    {
        public addinsurance()
        {
            InitializeComponent();
        }

        private void saveinsurance_btn_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO insurances(nameinsurance, telinsurance, emailinsurance, contractinsurance, pssinsurance) values('" + nameinsurance_txt.Text + "', '" + telinsurance_txt.Text + "','" + mailinsurance_txt.Text + "','" + contractinsurance_txt.Text + "', '" + pssinsurance_txt.Text + "')";
            DBManager c = new DBManager();
            c.command(insert);
            nameinsurance_txt.Clear();
            telinsurance_txt.Clear();
            mailinsurance_txt.Clear();
            contractinsurance_txt.Clear();
            pssinsurance_txt.Clear();

            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    SQLiteCommand insertion = new SQLiteCommand("INSERT INTO insurances(nameinsurance, telinsurance, emailinsurance, contractinsurance, pssinsurance) VALUES('" + nameinsurance_txt.Text + "', '" + telinsurance_txt.Text + "','" + mailinsurance_txt.Text + "','" + contractinsurance_txt.Text + "', '" + pssinsurance_txt.Text + "')", cnx);
            //    if (insertion.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Se agrego el seguro", "Hecho");
            //        nameinsurance_txt.Clear();
            //        telinsurance_txt.Clear();
            //        mailinsurance_txt.Clear();
            //        contractinsurance_txt.Clear();
            //        pssinsurance_txt.Clear();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");

            //}
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            nameinsurance_txt.Clear();
            telinsurance_txt.Clear();
            mailinsurance_txt.Clear();
            contractinsurance_txt.Clear();
            pssinsurance_txt.Clear();
        }
        public void clear_frm_addinsurance()
        {
            nameinsurance_txt.Clear();
            telinsurance_txt.Clear();
            mailinsurance_txt.Clear();
            contractinsurance_txt.Clear();
            pssinsurance_txt.Clear();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
