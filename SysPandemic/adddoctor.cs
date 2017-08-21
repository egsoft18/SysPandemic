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
            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Doctor/a?", "Eliminar Doctor", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                try
                {
                    cnx.Open();
                    string comando = "DELETE FROM doctors WHERE id = '" + iddoctor_txt.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha eliminado!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo fue mal");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void updatedoctor_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string comando = "UPDATE doctors set name = '" + namedoctor_txt.Text + "', sex = '" + sexdoctor_cb.Text + "', idperson = '" + idperson_txt.Text + "', address = '" + addressdoctor_txt.Text + "', tel = '" + teldoctor_txt.Text + "', cel = '" + celdoctor_txt.Text + "' WHERE id = '" + iddoctor_txt.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha actualizado!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo fallo!!!");
                    }
                }
                else if (result == DialogResult.No)
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void savedoctor_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string comando = "INSERT INTO doctors(name, sex, idperson, address, tel, cel) VALUES('" + namedoctor_txt.Text + "', '" + sexdoctor_cb.Text + "','" + idperson_txt.Text + "', '" + addressdoctor_txt.Text + "', '" + teldoctor_txt.Text + "', '" + celdoctor_txt.Text + "');";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente");
                    namedoctor_txt.Clear();
                    sexdoctor_cb.Text = "";
                    idperson_txt.Clear();
                    addressdoctor_txt.Clear();
                    teldoctor_txt.Clear();
                    celdoctor_txt.Clear();
                    namedoctor_txt.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

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
    }
}
