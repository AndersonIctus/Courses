using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Colecoes", 24));

            //um aluno também tem matricula
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            //precisamos matricular o aluno
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            //imprimindo alunos
            Console.WriteLine("Imprimindo alunos Matriculados");
            foreach(var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }
            //no formato [Nome, Matricula]

            Console.WriteLine($"O Aluno ai - {a1.Nome} está Matriculada ?" );
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);

            Console.WriteLine($"Tonini está Matriculada ? " + csharpColecoes.EstaMatriculado(tonini));

            //Mas a1 == tonini ??
            Console.WriteLine("a1 == tonini ??");
            Console.WriteLine(a1 == tonini);

            //Oq ocorreu ? a1 é equals a tonini ?
            Console.WriteLine("a1 é equals a Tonini ?");
            Console.WriteLine(a1.Equals(tonini) );

            //limpando o console
            Console.Clear();


            //pergunta: Quem é o aluno com matricula 5617?
            Console.WriteLine("Quem é o aluno com matricula 5617?");
            //impplementando Curso.BuscaMatriculado
            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);

            Console.WriteLine("Aluno5617 -> " + aluno5617);

            //um dicionario permite associar uma chave e um valor

            //Quem é o aluno 5618 ?
            Console.WriteLine("Quem é o Aluno 5618?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5618));

            //e se tentarmos adicionar outro alun com a mesmaa chave ??
            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            //csharpColecoes.Matricula(fabio);

            csharpColecoes.SubstiuiAluno(fabio);

        }
    }
}
