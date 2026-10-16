using MySql.Data.MySqlClient;
using SpotipucpDAO.Clases.DAO;
using SpotipucpDBManager;
using SpotipucpDomain.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SpotipucpDAO.Clases.Impl
{
    public class PlaylistCancionImpl : PlaylistCancionDAO
    {
        public int insertar(PlaylistCancion playlistCancion)
        {
            int resultado = 0;
            try
            {
                using MySqlConnection con = DBManager.Instance.Connection;
                using MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertar_playlist_cancion";
                cmd.Parameters.Add("p_id", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("p_id_cancion", playlistCancion.Cancion.Id);
                cmd.Parameters.AddWithValue("p_id_playlist", playlistCancion.Playlist.Id);
                cmd.Parameters.AddWithValue("p_orden", playlistCancion.Orden);
                cmd.ExecuteNonQuery();
                playlistCancion.Id = Int32.Parse(cmd.Parameters["p_id"].Value.ToString());
                resultado = playlistCancion.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar un area: " + ex.Message);
            }

            return resultado;
        }

        public List<PlaylistCancion> listarTodo()
        {
            throw new NotImplementedException();
        }

        public List<PlaylistCancion> listarPorIdPlaylist(int idPlaylist)
        {
            List<PlaylistCancion> playlistCanciones = null;
            try
            {
                using MySqlConnection con = DBManager.Instance.Connection;
                using MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "listar_canciones_por_playlist";
                cmd.Parameters.AddWithValue("p_id_playlist", idPlaylist);

                using MySqlDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    if (playlistCanciones == null) playlistCanciones = new List<PlaylistCancion>();

                    PlaylistCancion playlistCancion = new PlaylistCancion();
                    playlistCancion.Id = rs.GetInt32("id_playlist_cancion");
                    playlistCancion.Orden = rs.GetInt32("orden");

                    Cancion cancion = new Cancion();
                    cancion.Id = rs.GetInt32("id");
                    cancion.Titulo = rs.GetString("titulo");
                    cancion.Artista = rs.GetString("artista");
                    cancion.Genero = rs.GetString("genero");
                    cancion.DuracionSegundos = rs.GetInt32("duracion_segundos");

                    playlistCancion.Cancion = cancion;
                    playlistCanciones.Add(playlistCancion);
                }
                return playlistCanciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL LISTAR CANCIONES: " + ex.Message);
                throw new Exception("Error al listar canciones de la playlist", ex);
            }
        }
    }
}
