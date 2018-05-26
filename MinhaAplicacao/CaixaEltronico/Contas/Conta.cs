using Caelum.CaixaEltronico.Exceptions;
using Caelum.CaixaEltronico.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEltronico.Contas
{
    public class Conta
    {
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }
        public int NumeroCta { get; set; }
        
        public Conta(int numConta, string NomeTitular, double SaldoConta = 100.0)
        {
            this.Titular = new Cliente(NomeTitular);
            this.NumeroCta = numConta;
            this.Saldo = SaldoConta;
        }

        public virtual void Depositar(double valor)
        {
            if (valor <= 0) return;
            Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException();

            if (valor > this.Saldo)            
                throw new SaldoInsuficienteException();
            
            Saldo -= valor;
        }

        public override string ToString()
        {
            return this.NumeroCta + " - " + this.Titular.Nome;
        }
    }
}
