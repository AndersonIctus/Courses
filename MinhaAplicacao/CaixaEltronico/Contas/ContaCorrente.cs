
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Caelum.CaixaEltronico.Contas
{
    class ContaCorrente : Conta
    {
       
        public double ChequeEspecial { get; protected set; }
        public ContaCorrente(int numConta, string NomeTitular, double ChequeEspecial = 100.0, double SaldoConta = 100) : base(numConta, NomeTitular, SaldoConta)
        {
            this.ChequeEspecial = ChequeEspecial;
        }
    }
}