using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpDomain.Clases
{
    public class Playlist
    {
        private int id;
        private String nombre;
        private DateTime fechaCreacion;
        private Usuario usuario;
        private List<PlaylistCancion> canciones;

        public Playlist() { }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public List<PlaylistCancion> Canciones { get => canciones; set => canciones = value; }
    }
}
