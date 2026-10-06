using System;
using System.Collections.Generic;
using System.Text;

namespace SoftprogDAO.DAO
{
    public interface IDAO<T>
    {
        int Insertar(T objeto);
        int Modificar(T objeto);
        int Eliminar(int idObjeto);

        T BuscarPorId(int idObjeto);

        List<T> ListarTodos();
    }
}
