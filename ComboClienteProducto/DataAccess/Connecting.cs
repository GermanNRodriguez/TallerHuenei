using System.Data.SqlClient;

namespace DataAccess
{
    public class Connecting
    {
        
        public static SqlConnection Connect()
        {
            //Para cada uno con quien se comparta este codigo
            //Recuerde cambiar la direccion hacia la base de datos
            string Conexion = @"Data Source=GERNIROZ-PC\SQLEXPRESS; Initial Catalog=Taller; Integrated Security=true;";
            SqlConnection Connect = new SqlConnection(Conexion);
            Connect.Open();
            return Connect;

        }
        
    }
}
