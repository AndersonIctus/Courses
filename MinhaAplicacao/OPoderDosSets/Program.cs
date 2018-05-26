using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(",", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(",", alunos));

            //e a ordem ??
            //removendo ana, adicionando marcelo

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            Console.WriteLine(string.Join(",", alunos));

            //adicionando o gushiken novamente
            alunos.Add("Fabio Gushiken");

            //qual a vnatagem entre Sets e Listas ??
            //Sets sao mais rapidos para procurar referências (pois usam hash para busca !!)
            //Set usa tabela de espalhamento !!

            //HashSet x List : escalabilidade x memória

            //ordenando : sort
            //alunos.Sort(); //da erro, pois SET n tem ordenação !!

            //copiando a lista
            List<string> alunosEmList = new List<string>(alunos);
            //ordena copia
            alunosEmList.Sort();

            //imprimindo copia
            Console.WriteLine(string.Join(",", alunosEmList));

        }
    }
}
