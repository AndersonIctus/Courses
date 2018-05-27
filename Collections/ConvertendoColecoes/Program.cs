using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertendoColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string para object");
            string titulo = "meses";
            object obj = titulo;

            Console.WriteLine(obj); //string herda de object (alis, tudo herda de object)


            Console.WriteLine("List<string> para List<object>");
            IList<string> listaMeses = new List<string>()
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            //IList<object> listaObj = listaMeses; //nao consegue converter implicitamente !
            Console.WriteLine();

            Console.WriteLine("string[] para object[]?");
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            object[] arrayObj = arrayMeses; //Aqui ele consegue fazer a conversão (Covariancia em AÇÃO !)
            Console.WriteLine(arrayObj);
            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayObj[0] = "PRIMEIRO MES";           
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();

            //arrayObj[0] = 12345;      //Problemas de covariancia em arrays !!!
            //Console.WriteLine(arrayObj[0]);
            //Console.WriteLine();

            //
            Console.WriteLine("List<string> para IEnumerable<object>");
            IEnumerable<object> enumObj = listaMeses; //Sem problemas ! (COVARIANCIA TAMBÉM)

            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //enumObj[0] = 12345; //Nao deixa fazer, pois essa covariancia é segura
                                //(Assinatura está como IEnumarable<out T>, o out 
                                //assegura a manutenção do tipo !!


        }
    }
}
