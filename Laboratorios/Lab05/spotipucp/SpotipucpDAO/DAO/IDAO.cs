using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpDAO.DAO
{
    public interface IDAO<T>
    {
        List<T> listarTodo();

        int insertar (T objeto);
    }
}
