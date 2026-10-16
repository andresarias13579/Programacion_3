using SpotipucpBO.BO;
using SpotipucpDomain.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpBO.Clases.BOI
{
    public interface IPlaylistBO : IBaseBO<Playlist>
    {
        public void crearPlaylistConCanciones(Usuario usuario, string nombre, List<Cancion> canciones);
    }
}
