using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A51LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //imagine lista de frutas
            List<string> frutas = new List<string>()
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            //
            foreach(var fruta  in frutas)
            {
                Console.WriteLine(fruta);
            }

            //adicionar rapidamente um item no final da lista 
            //porem inserir no meio exige mais esforço computacional
            //os elentso tem q ser deslocados ...

            //Lista ligada
            //- os elemntos nao precisam estar em sequencia em memoria !!
            // cada elemnto sabe quem é o anterior e o proximo
            //cada elemnto é um nó que contem um valor 

            //a ordem é mantida usando um ponteiro ""!!

            //instanciando uma lista ligada ...
            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("quarta");

            //quarta é o primeiro elemnto da lista ligada !!
            Console.WriteLine("d4.value: " + d4.Value);

            //linkedlist n possui metodo ADD ...

            //1. Primeiro no add first
            //2. Ultimo no AddLast
            //3. antes de um no conhecido (addBefore)
            //4. depois de um no conhecido (AddAfter)

            var d2 = dias.AddBefore(d4, "segunda");
            //agora d2 e d4 estao ligados ...
            //d2.next == d4
            //d4.previous == d2

            var d3 = dias.AddAfter(d2, "terça");

            // os ponteiros de referencia de d2 e d4 foram direcionados apra d3 !!

            var d6 = dias.AddAfter(d4, "sexta");
            
            //sabado depois da sexta
            var d7 = dias.AddAfter(d6, "sabado");

            //quinta antes da sexta
            var d5 = dias.AddBefore(d6, "quinta");

            var d1 = dias.AddBefore(d2, "domingo");

            //imprimindo LISTA!!

            foreach(var dia in dias)
            {
                Console.WriteLine(dia);
            }

            //Linked list n dah suporte ao acesso de indice : dias[0] dá erro !!
            var quarta = dias.Find("quarta"); //mas nao é tao eficiente quanto na lsita !!

            //remove pelo nome ou indice
            //dias.Remove("quarta") ou dias.Remove(d4);

            dias.Remove("quarta");

            Console.WriteLine("-------------------------------------");
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

        }
    }
}
