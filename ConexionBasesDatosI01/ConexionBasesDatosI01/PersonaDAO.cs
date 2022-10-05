using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBasesDatosI01
{
    public static class PersonaDAO
    {
        private static string cadenaConexion;
        static PersonaDAO()
        {
            PersonaDAO.cadenaConexion = "Server=.;Database=MiPrimerCrud;Trusted_Connection=True;";
        }
        public static void Guardar(Persona persona)
        {
            string query = "insert into PersonasPrimerCrud (nombre, apellido) values (@nombre,@apellido)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(PersonaDAO.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("nombre",persona.Nombre);
                cmd.Parameters.AddWithValue("apellido", persona.Apellido);              
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// retornará la lista de personas de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            string query = "select * from PersonasPrimerCrud";
            try
            {
                using (SqlConnection conexion = new SqlConnection(PersonaDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        Persona persona = new Persona(id, nombre, apellido);
                        personas.Add(persona);
                    }
                }
                return personas;
            }catch(Exception)
            {
                throw;
            }
           
        }
        /// <summary>
        ///  traerá una persona, filtrando por ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Persona LeerPorId(int id )
        {
            Persona persona = null;
            string query = "select * from PersonasPrimerCrud where id =@id";
            try
            {
                using (SqlConnection connection = new SqlConnection(PersonaDAO.cadenaConexion))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        int ids = sqlDataReader.GetInt32(0);
                        string nombre = sqlDataReader.GetString(1);
                        string apellido = sqlDataReader.GetString(2);
                        persona = new Persona(ids,nombre,apellido);
                    }
                }
                return persona;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// modificará una persona a partir de su ID.
        /// </summary>
        /// <param name="id"></param>
        public static void Actualizar(Persona persona,int id)
        {
            string query = "update PersonasPrimerCrud set nombre = @nombre,apellido = @apellido where id = @id";
            try
            {
                using(SqlConnection connection = new SqlConnection(PersonaDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query,connection);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nombre",persona.Nombre);
                    cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void Borrar(int id)
        {
            string query = "delete from PersonasPrimerCrud where id = @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(PersonaDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
