using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpBO.BO
{
    public interface IBaseBO<T>
    {
        List<T> listarTodos();
        int Insertar(T objeto);
    }
}
