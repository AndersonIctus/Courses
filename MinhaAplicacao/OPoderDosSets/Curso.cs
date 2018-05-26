using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPoderDosSets
{
    class Curso
    {
        private List<Aula> aulas;
        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            aulas = new List<Aula>();
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //LINQ = Language INterated Querry (Consulta INtegrada a Linguagem)
                return aulas.Sum(a => a.Tempo);
            }
        }


        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }
    }
}
