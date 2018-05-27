using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacaoDeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            var consulta = seq1.Concat(seq2);
            showConsulta(consulta);

            Console.WriteLine("União de Sequencias ...");
            var consulta2 = seq1.Union(seq2);
            showConsulta(consulta2);

            Console.WriteLine("União de duas sequencias com comparador !");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            showConsulta(consulta3);

            Console.WriteLine("Interseção de duas sequencias !!");
            var consulta4 = seq1.Intersect(seq2);
            showConsulta(consulta4);

            Console.WriteLine("Interseção de duas sequencias com comparador!!");
            var consulta5 = seq1.Intersect(seq2, StringComparer.InvariantCultureIgnoreCase);
            showConsulta(consulta5);

            Console.WriteLine("Exeto: elementos de seq1 que não estão na seq2");
            var consulta6 = seq1.Except(seq2);
            showConsulta(consulta6);

        }

        private static void showConsulta(IEnumerable<string> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
