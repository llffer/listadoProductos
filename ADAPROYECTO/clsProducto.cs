using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ADAPROYECTO
{
    internal class clsProducto : clsConexion
    {
        //metodo parA mostrar LOS PRODUCTOS
        public DataTable ListarProductos()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from products",conectar1());
            DataTable dt=new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListarProductosNombre(string nomprod)
        {
            SqlCommand cmd = new SqlCommand("PA_PRODUCTONOMBRES", conectar1());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMPROD", nomprod);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
