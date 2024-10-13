using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADAPROYECTO
{
    internal class clsVenta : clsConexion
    {
        public DataTable MostrarVentaFecha (DateTime f1, DateTime f2)
        {
            SqlCommand cmd = new SqlCommand("PA_VENTASFECHA", conectar1());
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@F1", f1);
            cmd.Parameters.AddWithValue("@F2", f2);
            DataTable dt= new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
