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
    public partial class descpayrolldocext : Form
    {
        DBManager c = new DBManager();
        public descpayrolldocext()
        {
            InitializeComponent();
        }

        private void descpayrolldocext_Load(object sender, EventArgs e)
        {
            update();
        }
        private void update()
        {
            string querry = "select  namestaff from [staff] where idstaff > 1 and rolestaff='Doctor'";
            c.fill_CB(doctors_CB, querry, "namestaff");
            querry = "select  idstaff, namestaff from [staff] where idstaff = 1 and rolestaff='Doctor'";
            c.fill_txt(principaliddoctor_txt, querry, "idstaff");
            c.fill_txt(principalnamedoctor_txt, querry, "namestaff");
        }
        private void sum()
        {
            if (allpay_rbtn.Checked)
            {
                doctorpay_txt.Text = netopay_txt.Text;
            }
            else if (porcent_rbtn.Checked)
            {
                if(pordes_txt.Text.Length > 1)
                {
                    decimal porcent = Convert.ToDecimal(pordes_txt.Text) / 100;
                    decimal neto = Convert.ToDecimal(netopay_txt.Text);
                    doctorpay_txt.Text = Convert.ToString(neto * porcent);
                    pdoctorpay_txt.Text = Convert.ToString(neto - (neto * porcent));
                }
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void doctors_CB_TextChanged(object sender, EventArgs e)
        {
            string querry = "select idstaff from [staff] where namestaff = '" + doctors_CB.Text + "'";
            c.fill_txt(iddoctors, querry, "idstaff");
        }

        private void pordes_txt_TextChanged(object sender, EventArgs e)
        {
            porcent_rbtn.PerformClick();
            if (netopay_txt.Text.Length > 1)
            {
                sum();
            }
        }

        private void netopay_txt_TextChanged(object sender, EventArgs e)
        {
            if (netopay_txt.Text.Length > 1)
            {
                sum();
            }
            else if (netopay_txt.Text.Length < 1)
            {
                doctorpay_txt.Clear();
                pdoctorpay_txt.Clear();
            }
        }
        private void justnum()
        {
        }

        private void pordes_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void netopay_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void descpayrolldocext_Activated(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reasondesc_txt.Text.Length < 1)
            {
                MessageBox.Show("Debe de digitar la razon antes de guardar", "Error");
                reasondesc_txt.Focus();
            }
            else{
                
                if (allpay_rbtn.Checked)
                {
                    if (doctorpay_txt.Text.Length > 1 && pdoctorpay_txt.Text.Length < 1)
                    {
                        decimal doctordesc = Convert.ToDecimal(doctorpay_txt.Text) * -1;
                        string querry = "Insert into [payrolldoctors]([iddoctor], reason, qty, date) values ('" + iddoctors.Text + "', '" + reasondesc_txt.Text + "','"+doctordesc+"','" + datedesc_dtp.Text + "')";
                        c.command(querry);
                    }
                    else
                    {
                        MessageBox.Show("Algo no va como debe, verifique que solo el campo de texto MONTO A PAGAR DOCTOR tenga numeros", "Error");
                    }
                }
                else if (porcent_rbtn.Checked)
                {
                    if (doctorpay_txt.Text.Length > 1 && pdoctorpay_txt.Text.Length > 1)
                    {
                        decimal doctordesc = Convert.ToDecimal(doctorpay_txt.Text) * -1;
                        decimal pdoctordesc = Convert.ToDecimal(pdoctorpay_txt.Text) * -1;
                        string querry = "Insert into [payrolldoctors]([iddoctor], reason, qty, date) values ('" + iddoctors.Text + "', '" + reasondesc_txt.Text + "','" + doctordesc + "','" + datedesc_dtp.Text + "')";
                        c.command3(querry);
                        querry = "Insert into [payrolldoctors]([iddoctor], reason, qty, date) values ('1', '" + reasondesc_txt.Text + "','" + pdoctordesc + "','" + datedesc_dtp.Text + "')";
                        c.command(querry);
                    }
                    else
                    {
                        MessageBox.Show("Algo no va como debe, verifique que los campo de texto MONTO A PAGAR DOCTOR y MONTO A PAGAR PRIN DOCTOR tenga numeros", "Error");
                    }
                }
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
