using System;
using System.Collections.Generic;
using System.Text;
using Modelo.Clases;

namespace DAO.Clases.DAO
{
    public interface IAlumnoDAO
    {
        List<Alumno> Listar(string? texto);
        int Insertar(Alumno alumno);
    }
}
