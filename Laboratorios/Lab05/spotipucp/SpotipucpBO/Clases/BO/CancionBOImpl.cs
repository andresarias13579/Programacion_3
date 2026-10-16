using SpotipucpBO.Clases.BOI;
using SpotipucpDAO.Clases.DAO;
using SpotipucpDAO.Clases.Impl;
using SpotipucpDomain.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpBO.Clases.BO
{
    public class CancionBOImpl : ICancionBO
    {
        private CancionDAO daoCancion;

        public CancionBOImpl()
        {
            daoCancion = new CancionImpl();
        }

        public int Insertar(Cancion objeto)
        {
            throw new NotImplementedException();
        }

        public List<Cancion> listarTodos()
        {
            return daoCancion.listarTodo();
        }

        public List<Cancion> seleccionarCancionesAleatorias()
        {
            List<Cancion> catalogo = listarTodos();
            var rnd = new Random();
            return catalogo.OrderBy(c => rnd.Next()).Take(10).ToList();
        }
    }
}
