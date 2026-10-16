using SpotipucpBO.BO;
using SpotipucpDomain.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpBO.Clases.BOI
{
    public interface ICancionBO : IBaseBO<Cancion>
    {
        public List<Cancion> seleccionarCancionesAleatorias();
    }
}
