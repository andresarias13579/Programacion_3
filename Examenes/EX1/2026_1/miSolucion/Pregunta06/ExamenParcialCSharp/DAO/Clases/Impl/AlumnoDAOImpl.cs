using DAO.Clases.DAO;
using Modelo.Clases;
using MySql.Data.MySqlClient;
using DBManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO.Clases.Impl
{
    public class AlumnoDAOImpl : IAlumnoDAO
    {
        public List<Alumno> Listar(string? texto)
        {
            var lista = new List<Alumno>();

            // Connection ya viene abierta, no llamar a Open()
            using (MySqlConnection con = DBmanager.Instance.Connection)
            using (var cmd = new MySqlCommand("SP_LISTAR_ALUMNOS_X_NOMBRE_APELLIDO", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_texto", texto ?? "");

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string? estado = reader["estado"]?.ToString();
                        lista.Add(new Alumno
                        {
                            Id = reader.GetInt32("id"),
                            Codigo = reader.GetString("codigo"),
                            Nombre = reader.GetString("nombre"),
                            Apellidos = reader.GetString("apellidos"),
                            Correo = reader.GetString("correo"),
                            Estado = string.IsNullOrEmpty(estado) ? 'I' : estado[0]
                        });
                    }
                }
            }
            return lista;
        }

        public int Insertar(Alumno alumno)
        {
            using (MySqlConnection con = DBmanager.Instance.Connection)
            using (var cmd = new MySqlCommand("SP_INSERTAR_ALUMNO", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var pId = new MySqlParameter("p_id", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(pId);
                cmd.Parameters.AddWithValue("p_codigo", alumno.Codigo);
                cmd.Parameters.AddWithValue("p_nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("p_apellidos", alumno.Apellidos);
                cmd.Parameters.AddWithValue("p_correo", alumno.Correo);
                cmd.Parameters.AddWithValue("p_estado", alumno.Estado.ToString());

                cmd.ExecuteNonQuery();
                alumno.Id = Convert.ToInt32(pId.Value);
                return alumno.Id;
            }
        }
    }
}
