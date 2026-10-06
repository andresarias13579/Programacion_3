using System;
using System.Collections.Generic;
using System.Text;

namespace SoftprogBusinessLogic.BO
{
    public interface IBaseBO<T>
    {
        int Insertar(T objeto);
        int Modificar(T objeto);
        int Eliminar(int idObjeto);

        T BuscarPorId(int idObjeto);

        List<T> ListarTodos();

        T buscarPorId(int idObjeto);
    }
}
