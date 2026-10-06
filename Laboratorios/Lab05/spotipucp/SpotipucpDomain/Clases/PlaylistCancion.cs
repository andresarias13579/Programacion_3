using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpDomain.Clases
{
    public class PlaylistCancion
    {
        private int id;
        private int orden;
        private Playlist playlist;
        private Cancion cancion;

        public PlaylistCancion() { }

        public int Id { get => id; set => id = value; }
        public int Orden { get => orden; set => orden = value; }
        public Playlist Playlist { get => playlist; set => playlist = value; }
        public Cancion Cancion { get => cancion; set => cancion = value; }
    }
}
