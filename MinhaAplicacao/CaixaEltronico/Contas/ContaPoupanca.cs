using Caelum.CaixaEltronico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEltronico.Contas
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public ContaPoupanca(int numConta, string NomeTitular, double SaldoConta = 100) 
            : base(numConta, NomeTitular, SaldoConta)
        {
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor + 0.1;
        }

        public override void Depositar(double valor)
        {
            Saldo += valor - 0.1;
        }

        public double CalculaTributo()
        {
            return this.Saldo*0.02;
        }
    }
}
