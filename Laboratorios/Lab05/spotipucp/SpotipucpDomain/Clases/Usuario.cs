using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpDomain.Clases
{
    public class Usuario
    {
        private int id;
        private String codigo;
        private String nombre;
        private String correo;

        public Usuario() { }

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
