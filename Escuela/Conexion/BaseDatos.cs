using System.Configuration;
using System.Data.SqlClient; 


namespace Conexion
{
    public class BaseDatos
    {
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Prueba-Escuela"].ToString());
    }
}
