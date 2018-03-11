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
    public partial class variussubpro : Form
    {
        public variussubpro()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void variussubpro_Load(object sender, EventArgs e)
        {
        }

        private void addsubpro_btn_Click(object sender, EventArgs e)
        {
            DBManager c = new DBManager();
            c.valor = "";
            string status = "Sin Realizar";
            string query = "select idprocedure, subprocedure, tooth from subprocedure where idprocedure = '" + vsp_idprocedure_txt.Text + "' and subprocedure = '" + vsp_activity_txt.Text + "' and tooth = '" + vsp_tooth_txt.Text + "'";
            c.validation(query);
            if (c.valor == "si")
            {
                MessageBox.Show("No puede agregar el mismo sub-procedimiento al mismo diente dos veces.", "Error al agregar");
                c.valor = "";
            }
            else
            {

                string query2 = "INSERT INTO subprocedure(idprocedure, codeinsurance, subprocedure, tariff, coverage, difference, status, insurance, tooth) VALUES('" + vsp_idprocedure_txt.Text + "', '" + vsp_codeinsu_txt.Text + "','" + vsp_activity_txt.Text + "','" + vsp_tariff_txt.Text + "', '" + vsp_coverage_txt.Text + "', '" + vsp_difference_txt.Text + "', '" + status + "', '" + vsp_insurance_txt.Text + "', '" + vsp_tooth_txt.Text + "')";
                c.command(query2);
            }
        }
        private void sum()
        {
            decimal cobertura = Convert.ToDecimal(vsp_coverage_txt.Text);
            decimal tarifa = Convert.ToDecimal(vsp_tariff_txt.Text);

            decimal newtotal = tarifa - cobertura;
            vsp_difference_txt.Text = Convert.ToString(newtotal);
        }

        private void variussubpro_Activated(object sender, EventArgs e)
        {
            sum();
        }

        private void vsp_tariff_txt_TextChanged(object sender, EventArgs e)
        {
            if (vsp_tariff_txt.Text == "")
            {

            }
            else
            {
                sum();
            }
                
        }
    }
}
