using BO.Clases.BOI;
using DAO.Clases.DAO;
using DAO.Clases.Impl;
using Modelo.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace BO.Clases.BO
{
    public class AlumnoBOImpl : IAlumnoBO
    {
        private readonly IAlumnoDAO _alumnoDAO = new AlumnoDAOImpl();

        public List<Alumno> Listar(string? texto)
        {
            return _alumnoDAO.Listar(texto?.Trim());
        }

        public int Registrar(Alumno alumno)
        {
            if (string.IsNullOrWhiteSpace(alumno.Codigo) ||
                alumno.Codigo.Length != 8 ||
                !alumno.Codigo.All(char.IsDigit))
                throw new ArgumentException("El código debe tener 8 dígitos.");

            int anio = int.Parse(alumno.Codigo.Substring(0, 4));
            if (anio < 2020 || anio > 2025)
                throw new ArgumentException("El año de ingreso debe estar entre 2020 y 2025.");

            if (string.IsNullOrWhiteSpace(alumno.Nombre) ||
                string.IsNullOrWhiteSpace(alumno.Apellidos))
                throw new ArgumentException("Nombre y apellido son obligatorios.");

            if (string.IsNullOrWhiteSpace(alumno.Correo))
                throw new ArgumentException("El correo es obligatorio.");

            if (alumno.Estado != 'A' && alumno.Estado != 'I')
                throw new ArgumentException("Estado inválido.");

            return _alumnoDAO.Insertar(alumno);
        }
    }
}
