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
    public partial class insuranceadmi : Form
    {
        public insuranceadmi()
        {
            InitializeComponent();
        }

        private void insuranceadmi_Load(object sender, EventArgs e)
        {
            loadDGV();
        }
        private void loadDGV()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, Code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia from detailsinsurance where  idinsurance = '" + pidinsurance_txt.Text + "'", cnx);
                DataTable tabla = new DataTable("Detallesdeseguro");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void adddetail_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                if (id_txt.Text == "")
                {
                    cnx.Open();
                    string comando = "INSERT INTO detailsinsurance(Code, pinsurance, tariff, coverage, difference, idinsurance, insurance) VALUES('" + code_txt.Text + "', '" + procedure_txt.Text + "','" + tariff_txt.Text + "', '" + coverage_txt.Text + "', '" + difference_txt.Text + "', '" + pidinsurance_txt.Text + "', '" + pnameinsurance_txt.Text + "');";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);

                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se agrego correctamente");
                        code_txt.Clear();
                        procedure_txt.Clear();
                        tariff_txt.Clear();
                        coverage_txt.Clear();
                        difference_txt.Clear();
                        loadDGV();

                    }
                }
                else
                {
                    cnx.Open();
                    DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string comando = "UPDATE detailsinsurance set code = '" + code_txt.Text + "', pinsurance = '" + procedure_txt.Text + "', tariff = '" + tariff_txt.Text + "', coverage = '" + coverage_txt.Text + "', difference = '" + difference_txt.Text + "' WHERE id = '" + id_txt.Text + "'";
                        SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                        if (insertion.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Se ha actualizado!");
                            id_txt.Clear();
                            code_txt.Clear();
                            procedure_txt.Clear();
                            tariff_txt.Clear();
                            coverage_txt.Clear();
                            difference_txt.Clear();
                            loadDGV();
                        }
                        else
                        {
                            MessageBox.Show("Algo fallo!!!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
       
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
                id_txt.Text = act.Cells["ID"].Value.ToString();
                code_txt.Text = act.Cells["Codigo"].Value.ToString();
                procedure_txt.Text = act.Cells["Descripcion"].Value.ToString();
                tariff_txt.Text = act.Cells["Tarifa"].Value.ToString();
                coverage_txt.Text = act.Cells["Cobertura"].Value.ToString();
                difference_txt.Text = act.Cells["Diferencia"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void deletedetail_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_txt.Text == "")
                {
                    MessageBox.Show("No puede borrar este registro; no ha seleccionado uno de los del visor para esto.", "Error");
                }
                else{
                    try
                    {
                        SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                        cnx.Open();
                        string comando = "DELETE FROM detailsinsurance WHERE id = '" + id_txt.Text + "'";
                        SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                        if (insertion.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Se ha actualizado!");
                            id_txt.Clear();
                            code_txt.Clear();
                            procedure_txt.Clear();
                            tariff_txt.Clear();
                            coverage_txt.Clear();
                            difference_txt.Clear();
                            loadDGV();
                        }
                        else
                        {
                            MessageBox.Show("Algo fallo!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Errror");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void updateinsurance_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            cnx.Open();
            DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string comando = "UPDATE insurances set nameinsurance = '" + pnameinsurance_txt.Text + "', telinsurance = '" + ptelinsurance_txt.Text + "', emailinsurance = '" + pmailinsurance_txt.Text + "', contractinsurance = '" + pcontractinsurance_txt.Text + "', pssinsurance = '" + ppssinsurance_txt.Text + "' WHERE idinsurance = '" + pidinsurance_txt.Text + "'";
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
        }

        private void deleteinsurance_txt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Borrar?", "Borrar datos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                    cnx.Open();
                    string comando = "DELETE FROM insurances WHERE idinsurance = '" + pidinsurance_txt.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha actualizado!");
                        Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {

            }
        }

        private void tariff_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void coverage_txt_KeyPress(object sender, KeyPressEventArgs e)
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
        private void calcule()
        {
            

            if (tariff_txt.Text.Length > 0 && coverage_txt.Text.Length > 0)
            {
                decimal tariff = Convert.ToDecimal(tariff_txt.Text);
                decimal coverage = Convert.ToDecimal(coverage_txt.Text);
                decimal difference = tariff - coverage;
                difference_txt.Text = Convert.ToString(difference);
            }
            else if (tariff_txt.Text.Length > 0 && coverage_txt.Text == "")
            {
                decimal tariff = Convert.ToDecimal(tariff_txt.Text);
                difference_txt.Text = Convert.ToString(tariff);
            }
            else if (tariff_txt.Text == "" && coverage_txt.Text == "")
            {
                difference_txt.Text = "";
            }
        }

        private void tariff_txt_TextChanged(object sender, EventArgs e)
        {
            calcule();
        }

        private void coverage_txt_TextChanged(object sender, EventArgs e)
        {
            calcule();
        }
        
    }
}
