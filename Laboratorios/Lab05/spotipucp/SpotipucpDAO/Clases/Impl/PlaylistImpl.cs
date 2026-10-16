using MySql.Data.MySqlClient;
using SpotipucpDAO.Clases.DAO;
using SpotipucpDBManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using SpotipucpDomain.Clases;

namespace SpotipucpDAO.Clases.Impl
{
    public class PlaylistImpl : PlaylistDAO
    {
        public int insertar(Playlist playlist)
        {
            int resultado = 0;
            try
            {
                using MySqlConnection con = DBManager.Instance.Connection;
                using MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertar_playlist";
                cmd.Parameters.Add("p_id", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("p_id_usuario",playlist.Usuario.Id);
                cmd.Parameters.AddWithValue("p_fecha_creacion", playlist.FechaCreacion);
                cmd.Parameters.AddWithValue("p_nombre", playlist.Nombre);
                cmd.ExecuteNonQuery();
                playlist.Id = Int32.Parse(cmd.Parameters["p_id"].Value.ToString());
                resultado = playlist.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar un area: " + ex.Message);
            }

            return resultado;
        }

        public List<Playlist> listarTodo()
        {
            List<Playlist> playlists = null;
            try
            {
                using MySqlConnection con = DBManager.Instance.Connection;
                using MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "listar_playlists";

                using MySqlDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    if (playlists == null) playlists = new List<Playlist>();

                    Playlist playlist = new Playlist();
                    playlist.Id = rs.GetInt32("id");
                    playlist.Nombre = rs.GetString("nombre");
                    playlist.FechaCreacion = rs.GetDateTime("fecha_creacion");

                    Usuario usuario = new Usuario();
                    usuario.Id = rs.GetInt32("id_usuario");
                    usuario.Codigo = rs.GetString("codigo_usuario");
                    usuario.Nombre = rs.GetString("nombre_usuario");
                    usuario.Correo = rs.GetString("correo_usuario");

                    playlist.Usuario = usuario;
                    playlists.Add(playlist);
                }
                return playlists;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL LISTAR PLAYLISTS: " + ex.Message);
                throw new Exception("Error al listar playlists", ex);
            }
        }
    }
}
