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
    public partial class doctorpayroll : Form
    {
        DBManager c = new DBManager();
        public doctorpayroll()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void doctorpayroll_Load(object sender, EventArgs e)
        {
            string querry = "select namestaff, idpersonstaff from [staff] where idstaff = '" + IdDoctorPR_txt.Text + "'";
            c.fill_txt(namedoctor_txt, querry, "namestaff");
            c.fill_txt(idpersondoctor_txt, querry, "idpersonstaff");

            querry = "select prd.idpayment as ID, namepatient as Paciente, prd.reason as Rezon, prd.qty as Cantidad, prd.[date] as Fecha from payrolldoctors prd where prd.iddoctor = '" + IdDoctorPR_txt.Text + "' order by prd.idpayment";
            c.load_dgv(dataGridView1, querry);
        }

        private void doctorpayroll_Activated(object sender, EventArgs e)
        {
            string querry = "select prd.idpayment as ID, namepatient as Paciente, prd.reason as Rezon, prd.qty as Cantidad, prd.[date] as Fecha from payrolldoctors prd where prd.iddoctor = '" + IdDoctorPR_txt.Text + "' order by prd.idpayment";
            c.load_dgv(dataGridView1, querry);

            Decimal result = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Cantidad"].Value));
            topay_txt.Text = Convert.ToString(result);
            
        }

        private void datestart_dtp_ValueChanged(object sender, EventArgs e)
        {
            dateselect();
        }
        private void dateselect()
        {
            string querry = "select prd.idpayment as ID, namepatient as Paciente, prd.reason as Rezon, prd.qty as Cantidad, prd.[date] as Fecha from payrolldoctors prd where prd.iddoctor = '" + IdDoctorPR_txt.Text + "'  and date >= '" + datestart_dtp.Text + "' and date <= '" + dateend_dtp.Text + "' order by prd.idpayment";
            c.load_dgv(dataGridView1, querry);

            Decimal result = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Cantidad"].Value));
            topay_txt.Text = Convert.ToString(result);
        }

        private void dateend_dtp_ValueChanged(object sender, EventArgs e)
        {
            dateselect();
        }

        private void genpayroll_btn_Click(object sender, EventArgs e)
        {
            string querry = "select prd.idpayment as ID, namepatient as Paciente, prd.reason as Rezon, prd.qty as Cantidad, prd.[date] as Fecha from payrolldoctors prd where prd.iddoctor = '" + IdDoctorPR_txt.Text + "'  and date >= '" + datestart_dtp.Text + "' and date <= '" + dateend_dtp.Text + "' order by prd.idpayment";
            c.test_printreport(querry, "payment", "doctorspayroll.xml", "payrolldoctor.rpt");
            querry = "select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula, telstaff as Telefono, celstaff as Celular from [staff] where idstaff = '" + IdDoctorPR_txt.Text + "'";
            c.printreport(querry, "infodoctor", "infodoctor.xml", "payrolldoctor.rpt");    

        }
    }
}
