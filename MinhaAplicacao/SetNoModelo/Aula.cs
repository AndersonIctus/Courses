using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNoModelo
{
    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return -1;

            Aula aulaOther = obj as Aula;
            return this.titulo.CompareTo(aulaOther.titulo);
        }

        public override string ToString()
        {
            return $"[Título: {titulo}, Tempo: {tempo} minutos]";
        }
    }
}
