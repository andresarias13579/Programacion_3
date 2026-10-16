using Modelo.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace BO.Clases.BOI
{
    public interface IAlumnoBO
    {
        List<Alumno> Listar(string? texto);
        int Registrar(Alumno alumno);
    }
}
