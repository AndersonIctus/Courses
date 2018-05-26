using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNoModelo
{
    class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }


        public override string ToString()
        {
            return $"[Nome: {nome}, Matricula: {numeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Aluno other = obj as Aluno;
            return this.nome.Equals(other.nome) && this.numeroMatricula == other.numeroMatricula;
        }

        public override int GetHashCode()
        {
            return nome.GetHashCode() + numeroMatricula;
        }
    }
}
