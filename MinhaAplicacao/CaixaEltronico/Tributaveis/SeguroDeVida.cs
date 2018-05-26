using Caelum.CaixaEltronico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEltronico.Tributaveis
{
    class SeguroDeVida : ITributavel
    {
        public double CalculaTributo()
        {
            return 42.00;
        }
    }
}
