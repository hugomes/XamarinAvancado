using System;
using System.Collections.Generic;
using System.Text;

namespace ListView.Model
{
    public class Grupo : List<Pessoa>
    {
        public string Titulo { get; set; }
        public string TituloCurto { get; set; }

        public Grupo(string titulo, string tituloCurto)
        {
            Titulo = titulo;
            TituloCurto = tituloCurto;
        }
    }
}
