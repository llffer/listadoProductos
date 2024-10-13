using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
//connection with sqlServer
using System.Data.SqlClient;
using System.Configuration;

namespace ADAPROYECTO
{
    internal class clsConexion
    {
        protected SqlConnection conectar()
        {
            SqlConnection cnx = new SqlConnection
                (ConfigurationManager.ConnectionStrings["XCON"].ConnectionString);
            if (cnx.State==ConnectionState.Open)
            {
                cnx.Close();

            }
            else
            {
                cnx.Open();
            }
            return cnx;
        }


        protected SqlConnection conectar1()
        {
            SqlConnection cnx = new SqlConnection
                (ConfigurationManager.ConnectionStrings["XCON1"].ConnectionString);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();

            }
            else
            {
                cnx.Open();
            }
            return cnx;
        }

    }
}
