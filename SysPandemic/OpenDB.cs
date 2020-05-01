using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SysPandemic
{
    class OpenDB
    {
        public SqlConnection cnx;
        public OpenDB()
        {
            try
            {
                //Conexion en PC de desarrollo
                //cnx = new SqlConnection(@"Server=DESKTOP-8IKC9CN\SQLEXPRESS;Database=SysPandemic;User Id=egsoft; Password=1234; MultipleActiveResultSets=True");

                //Conexion en el servidor SOMEE
                cnx = new SqlConnection(@"Server=SysPandemic.mssql.somee.com;Database=SysPandemic;User Id=egsoft_SQLLogin_1; Password=gihpmzkagd; MultipleActiveResultSets=True");

                cnx.Open();
                //MessageBox.Show("Conectado 1 ");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar " + ex.Message, "Error al conectar");

            }
        }
    }
}
