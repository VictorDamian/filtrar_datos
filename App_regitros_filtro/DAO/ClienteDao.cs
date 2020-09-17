using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using App_regitros_filtro.DTO;

namespace App_regitros_filtro.DAO
{
    class ClienteDao : ConexionBD
    {
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();
        //METODOS CRUD
        //no es recomendable usar DataTable ya que consume mucha RAM
        //es mejor usar metodos serializables
        public List<ClientesDto> verRegistros(string Condicion)
        {
            Comando.Connection = con;
            Comando.CommandText = "verRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion",Condicion);

            con.Open();

            LeerFilas = Comando.ExecuteReader();
            List<ClientesDto> ListaGenereica = new List<ClientesDto>();
            while (LeerFilas.Read())
            {
                ListaGenereica.Add(new ClientesDto
                {
                    ID = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            con.Close();
            return ListaGenereica; 
        }
        public void Insertar() { }
        public void Eliminar() { }
        public void Editar() { }


    }
}
