using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A53Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            //entrou: van
            Enfileirar("van");

            //adiciona Kombi
            Enfileirar("kombi");

            //entru: gincho
            Enfileirar("guincho");

            //entrou: pickup
            Enfileirar("pickup");

            //liberando o carro
            Desenfileirar();

            //liberando mais um carro
            Desenfileirar();

            //liberando mais um carro (guincho)
            Desenfileirar();

            //liberando mais um carro (guincho)
            Desenfileirar();

            //liberando mais um carro (guincho)
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if(pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("O Guincho esta fazendo o pagamento!!");
                }

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da Fila: {veiculo}");

                ImprimirFila();
            }

        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA: ");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
