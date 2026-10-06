using System;
using System.Collections.Generic;
using System.Text;

namespace SpotipucpDomain.Clases
{
    public class Cancion
    {
        private int id;
        private String titulo;
        private String artista;
        private String genero;
        private int duracionSegundos;

        public Cancion() { }

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Genero { get => genero; set => genero = value; }
        public int DuracionSegundos { get => duracionSegundos; set => duracionSegundos = value; }
    }
}
