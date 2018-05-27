using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var meses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var mes in meses)
            {
                Console.WriteLine(mes);
            }



        }
    }
}
