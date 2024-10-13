using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

// validar usuario - baseDatos ADAPROYECTO
namespace ADAPROYECTO
{
    internal class clsUsuario :clsConexion //herencia de clases
    {

        //metodo
        public Boolean verificarUsuario(string nomusu,string claveusu)
        {
            SqlCommand cmd = new SqlCommand("pa_validarUsuario", conectar());
            cmd.CommandType = CommandType.StoredProcedure  ;
            cmd.Parameters.AddWithValue("@nomusu", nomusu) ;
            cmd.Parameters.AddWithValue("@claveusu", claveusu);
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.HasRows==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
