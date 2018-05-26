using Caelum.CaixaEltronico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEltronico.Gerenciadores
{
    public class GerenciadorDeImposto
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel tributavel)
        {
            this.Total += tributavel.CalculaTributo();
        }
    }
}
