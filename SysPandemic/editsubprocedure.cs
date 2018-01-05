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
    
    public partial class editsubprocedure : Form
    {
        DBManager c = new DBManager();
        public editsubprocedure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(ep_ta_txt.Text) && string.IsNullOrEmpty(ep_cov_txt.Text))
                {
                    MessageBox.Show("No ha dijitado valores en los campos de tearifa y cobertura, favor revisar.", "Error");
                }
                else if (string.IsNullOrEmpty(ep_ta_txt.Text) == false && string.IsNullOrEmpty(ep_cov_txt.Text))
                {
                    string query = "Update subprocedure set tariff = '" + ep_ta_txt.Text + "', coverage = '0', difference = '" + ep_dif_txt.Text + "' where id = '"+ep_id_txt.Text+"'";
                    c.command3(query);
                    this.Close();
                }
                else if (string.IsNullOrEmpty(ep_ta_txt.Text) && string.IsNullOrEmpty(ep_cov_txt.Text) == false)
                {
                    string query = "Update subprocedure set tariff = '0', coverage = '" + ep_cov_txt.Text + "', difference = '" + ep_dif_txt.Text + "' where id = '" + ep_id_txt.Text + "'";
                    c.command3(query);
                    this.Close();
                }
                else if (string.IsNullOrEmpty(ep_ta_txt.Text) == false && string.IsNullOrEmpty(ep_cov_txt.Text) == false)
                {
                    string query = "Update subprocedure set tariff = '" + ep_ta_txt.Text + "', coverage = '" + ep_cov_txt.Text + "', difference = '" + ep_dif_txt.Text + "' where id = '" + ep_id_txt.Text + "'";
                    c.command3(query);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. Motivo: " +ex.Message, "Error");
            }

            finally
            {
                try
                {
                    addprocedure f = new addprocedure();
                    f.loadsubprocedure();
                    f.sums();
                }
                catch
                {
                    MessageBox.Show("No mando a cargar.");
                }
            }
        }

        private void editsubprocedure_Load(object sender, EventArgs e)
        {
            Sum();
            //string query = "Select id, idprocedure, codeinsurance, subprocedure, tariff, coverage, difference from subprocedure where idprocedure = '" + ep_id_txt + "'";

            //c.fill_txt(ep_idpro_txt, query, "idprocedure");
            //c.fill_txt(ep_code_txt, query, "codeinsurance");
            //c.fill_txt(ep_pro_txt, query, "subprocedure");
            //c.fill_txt(ep_ta_txt, query, "tariff");
            //c.fill_txt(ep_cov_txt, query, "coverage");
            //c.fill_txt(ep_dif_txt, query, "difference");

        }
        public void Sum()
        {

            if (string.IsNullOrEmpty(ep_ta_txt.Text) && string.IsNullOrEmpty(ep_cov_txt.Text))
            {
                ep_dif_txt.Text = "0";
            }
            else if (string.IsNullOrEmpty(ep_ta_txt.Text) == false && string.IsNullOrEmpty(ep_cov_txt.Text))
            {
                ep_dif_txt.Text = ep_ta_txt.Text;
            }
            else if (string.IsNullOrEmpty(ep_ta_txt.Text) && string.IsNullOrEmpty(ep_cov_txt.Text) == false)
            {
                ep_dif_txt.Text = ep_cov_txt.Text;
            }
            else if (string.IsNullOrEmpty(ep_ta_txt.Text) == false && string.IsNullOrEmpty(ep_cov_txt.Text) == false)
            {
                int result = Convert.ToInt32(ep_ta_txt.Text) - Convert.ToInt32(ep_cov_txt.Text);
                ep_dif_txt.Text = Convert.ToString(result);
            }
         
        }

        private void ep_ta_txt_TextChanged(object sender, EventArgs e)
        {
            
                Sum();
            
        }

        private void ep_cov_txt_TextChanged(object sender, EventArgs e)
        {
            Sum();
        }

        private void ep_ta_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ep_cov_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ep_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Seguro que desea Borrar?", "Borrar Sub-Procedimiento", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM subprocedure WHERE id = '" + ep_id_txt.Text + "'";
                    c.command(query);
                    this.Close();
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
    }
}
