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
    public partial class managerprovider : Form
    {
        DBManager c = new DBManager();
        public managerprovider()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void managerprovider_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idprovider_txt.Text))
            {
                proccess_btn.Text = "Agregar";
            }
            else
            {
                proccess_btn.Text = "Actualizar";
                string query = "select * from provider where idprovider = '" + idprovider_txt.Text + "'";
                c.fill_txt(nameprovider, query, "nameprovider");
                c.fill_txt(addressprovider, query, "addressprovider");
                c.fill_txt(telprovider, query, "phoneprovider");
                c.fill_txt(emailprovider, query, "email");
                c.fill_txt(namecontactp, query, "namecontactp");
                c.fill_txt(telcontactp, query, "phonecontactp");
                c.fill_txt(positioncontactp, query, "contactpposition");
            }
        }

        private void proccess_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idprovider_txt.Text))
            {
                string query = "insert into [provider](nameprovider, addressprovider, phoneprovider, email, namecontactp, contactpposition, phonecontactp) values('" + nameprovider.Text + "', '" + addressprovider.Text + "', '" + telprovider.Text + "', '" + emailprovider.Text + "', '" + namecontactp.Text + "', '" + telcontactp.Text + "', '" + positioncontactp.Text + "')";
                c.command(query);
                nameprovider.Clear();
                addressprovider.Clear();
                telprovider.Clear();
                emailprovider.Clear();
                namecontactp.Clear();
                telcontactp.Clear();
                positioncontactp.Clear();
            }
            else
            {
                string query = "update [provider] set nameprovider = '" + nameprovider.Text + "', addressprovider = '" + addressprovider.Text + "', phoneprovider = '" + telprovider.Text + "', email = '" + emailprovider.Text + "', namecontactp = '" + namecontactp.Text + "', contactpposition = '" + positioncontactp.Text + "', phonecontactp = '" + telcontactp.Text + "'";
                c.command(query);
                this.Close();
                suppliers f = new suppliers();
                string query2 = "select idprovider as ID, nameprovider as Nombre, addressprovider as Direccion, phoneprovider as Telefono, email as 'E-mail' from [provider]";
                c.load_dgv(f.providers_dgv, query2);
            }
        }
    }
}
