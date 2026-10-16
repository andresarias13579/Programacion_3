using SpotipucpDAO.DAO;
using SpotipucpDomain.Clases;

namespace SpotipucpDAO.Clases.DAO
{
    public interface PlaylistCancionDAO : IDAO<PlaylistCancion>
    {
        public List<PlaylistCancion> listarPorIdPlaylist(int idPlaylist);
    }
}
