using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class GestorSQL
    {
        private static string cadenaConexion;
        static GestorSQL()
        {
            GestorSQL.cadenaConexion = "Server=.;Database=DIV2EClase17;Trusted_Connection=True;";
            //esta ruta se usa siempre
        }


        public static List<Persona> LeerDatos()
        {
            List<Persona> personas = new List<Persona>();

            string query = "select * from personas";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();//abrir la conexion
                SqlDataReader reader = cmd.ExecuteReader();
                //Mientras pueda leer - tenga contenido en mi reader--lee fila a fila
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);//0 es donde incia la fila
                    string nombre = reader.GetString(1);//reader["nombre"].ToString(); otra forma
                    string apellido = reader.GetString(2);
                    string email = reader.GetString(3);
                    string sexo = reader.GetString(4);
                    int edad = reader.GetInt32(5);
                    Persona persona = new Persona(id, nombre, email, apellido, sexo, edad);
                    personas.Add(persona);
                }    
            }

            return personas;
        }
        public static Persona LeerDatosPorId(int id)
        {
            Persona persona= null;

            string query = "select * from personas where id=@id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id",id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string email = reader.GetString(3);
                    string sexo = reader.GetString(4);
                    int edad = reader.GetInt32(5);
                    persona = new Persona(id, nombre, email, apellido, sexo, edad);
                }
            }

            return persona;
        }
        public static void Alta(Persona persona)
        {
            string query = "insert into personas (nombre, apellido, email, sexo, edad) values (@nombre,@apellido,@email,@sexo,@edad)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.Parameters.AddWithValue("nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                cmd.Parameters.AddWithValue("email", persona.Email);
                cmd.Parameters.AddWithValue("sexo", persona.Sexo);
                cmd.Parameters.AddWithValue("edad", persona.Edad);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close(); 
                }
            }
        }

        public static void Borrar(int id)
        {


            string query = "delete from personas where id = @id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void Actualizar(Persona persona, int id)
        {


            string query = "update personas set nombre=@nombre, apellido=@apellido, email=@email, sexo=@sexo, edad=@edad where id = @id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                cmd.Parameters.AddWithValue("email", persona.Email);
                cmd.Parameters.AddWithValue("sexo", persona.Sexo);
                cmd.Parameters.AddWithValue("edad", persona.Edad);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
