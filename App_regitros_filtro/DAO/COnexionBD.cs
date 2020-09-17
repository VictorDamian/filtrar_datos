using System.Data.SqlClient;

namespace App_regitros_filtro.DAO
{
    class ConexionBD
    {
        protected SqlConnection con = new SqlConnection("Server=DANTES\\DANTES;DataBase=Practica_Patrones;Integrated Security=true");

    }
}
