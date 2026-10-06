using SoftprogBusinessLogic.RRHH.BOI;
using SoftprogDAO.RRHH.DAO;
using SoftprogDAO.RRHH.Impl;
using SoftprogDomain.RRHH;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftprogBusinessLogic.RRHH.BO
{
    public class AreaBOImpl : IAreaBO
    {
        private AreaDAO daoArea;

        public AreaBOImpl()
        {
            daoArea = new AreaImpl();
        }
        public Area BuscarPorId(int idObjeto)
        {
            throw new NotImplementedException();
        }

        public Area buscarPorId(int idObjeto)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idObjeto)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Area area)
        {
            if (area == null)
                throw new Exception("El area que se quiere registrar es null");
            if (area.Nombre == null)
                throw new Exception("El nombre del area que se quiere registrar es null");

            if (area.Nombre.Trim().Length == 0)
                throw new Exception("El nombre del area no puede estar llena de espacios en blanco");

            if (area.Nombre.Trim().Length > 45)
                throw new Exception("El nombre del area no puede tener mas de 45 caracteres");

            return daoArea.Insertar(area);
        }

        public List<Area> ListarTodos()
        {
            return daoArea.ListarTodos();
        }

        public int Modificar(Area objeto)
        {
            throw new NotImplementedException();
        }
    }
}
