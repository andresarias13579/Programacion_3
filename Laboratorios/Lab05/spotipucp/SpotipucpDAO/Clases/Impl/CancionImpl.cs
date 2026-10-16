using SpotipucpDAO.Clases.DAO;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using SpotipucpDomain.Clases;
using SpotipucpDBManager;
using System.Data;

namespace SpotipucpDAO.Clases.Impl
{
    public class CancionImpl : CancionDAO
    {
        public int insertar(Cancion objeto)
        {
            throw new NotImplementedException();
        }

        public List<Cancion> listarTodo()
        {
            using MySqlConnection con = DBManager.Instance.Connection;
            using MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listar_canciones";
            using MySqlDataReader reader = cmd.ExecuteReader();
            List<Cancion> canciones = new List<Cancion>();
            while (reader.Read()) { 
                Cancion cancion = new Cancion();
                cancion.Id = reader.GetInt32("id");
                cancion.DuracionSegundos = reader.GetInt32("duracion_segundos");
                cancion.Titulo = reader.GetString("titulo");
                cancion.Artista = reader.GetString("artista");
                cancion.Genero = reader.GetString("genero");
                canciones.Add(cancion);
            }
            return canciones;
        }
    }
}
