using SoftProgDBManager;
using SpotipucpBO.Clases.BOI;
using SpotipucpDAO.Clases.DAO;
using SpotipucpDAO.Clases.Impl;
using SpotipucpDomain.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpBO.Clases.BO
{
    public class PlaylistBOImpl : IPlaylistBO
    {
        private PlaylistDAO daoPlaylist;
        private PlaylistCancionDAO daoPlaylistCancion;
        public PlaylistBOImpl()
        {
            daoPlaylist = new PlaylistImpl();
            daoPlaylistCancion = new PlaylistCancionImpl();
        }

        public int Insertar(Playlist objeto)
        {
            throw new NotImplementedException();
        }

        public List<Playlist> listarTodos()
        {
            List<Playlist> playlists = daoPlaylist.listarTodo();
            if (playlists == null) return new List<Playlist>();

            foreach (Playlist playlist in playlists)
                playlist.Canciones = daoPlaylistCancion.listarPorIdPlaylist(playlist.Id);

            return playlists;
        }

        public void crearPlaylistConCanciones(Usuario usuario, string nombre, List<Cancion> canciones)
        {
            Playlist playlist = new Playlist();
            playlist.Usuario = usuario;
            playlist.Nombre = nombre;
            playlist.FechaCreacion = DateTime.Now;   // o DateOnly.FromDateTime(DateTime.Now) si usas DateOnly

            List<PlaylistCancion> playlistCanciones = new List<PlaylistCancion>();
            int i = 1; /* indice para el orden */
            foreach (Cancion cancion in canciones)
            {
                PlaylistCancion playlistCancion = new PlaylistCancion();
                playlistCancion.Orden = i++;
                playlistCancion.Playlist = playlist;
                playlistCancion.Cancion = cancion;
                playlistCanciones.Add(playlistCancion);
            }
            playlist.Canciones = playlistCanciones;

            try
            {
                int resultado = daoPlaylist.insertar(playlist);
                foreach (Cancion cancion in canciones)
                {
                    PlaylistCancion playlistCancion = new PlaylistCancion();
                    playlistCancion.Orden = i++;
                    playlistCancion.Playlist = playlist;          // ya tiene Id
                    playlistCancion.Cancion = cancion;
                    daoPlaylistCancion.insertar(playlistCancion);
                }
                TransactionContext.Commit();
                if (resultado != 0)
                    Console.WriteLine("Se ha registrado la playlist del usuario: " + playlist.Usuario.Nombre);
            }
            catch (Exception ex)
            {
                TransactionContext.RollBack();
                throw new Exception("Error registrando la playlist: " + ex.Message, ex);
            }
            finally
            {
                TransactionContext.Close();
            }
        }
    }
}
