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
    public partial class addpwi : Form
    {
        public addpwi()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void savepwi_btn_Click(object sender, EventArgs e)
        {
            if (process_txt.Text.Length < 1)
            {
                MessageBox.Show("Debe de introducir la informacion requerida.", "Error");
            }
            else
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                try
                {
                    cnx.Open();
                    string idinsurance = "0";
                    string insurance = "NO SEGURO";
                    string comando = "INSERT INTO detailsinsurance(pinsurance, tariff,  idinsurance, insurance) VALUES('" + process_txt.Text + "', '" + priceprocess_txt.Text + "','" + idinsurance + "', '" + insurance + "');";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);

                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se agrego correctamente");
                        process_txt.Clear();
                        priceprocess_txt.Clear();
                        process_txt.Focus();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        
    }

        private void updatepwi_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");

            try
            {
                
                cnx.Open();
                string comando = "UPDATE detailsinsurance set pinsurance = '" + process_txt.Text + "', tariff = '" + priceprocess_txt.Text + "' where id= '" +idprocess_txt+"'";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se ha actualizado!");
                    Close();
                    seepwi frm = new seepwi();
                    frm.loaddgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
}
    }