using Caelum.CaixaEltronico.Contas;
using Caelum.CaixaEltronico.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caelum.CaixaEltronico
{
    public partial class Form2 : Form
    {
        private Conta c;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            c = new Conta(123, "teste");
            c.Depositar(250.0);
            c.Titular = new Cliente("Victor");

            MostraConta();
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            c.Depositar(Convert.ToDouble(txtValorDepositar.Text));
            MostraConta();
        }
        
        private void btSacar_Click(object sender, EventArgs e)
        {
            try
            {
                c.Sacar(Convert.ToDouble(txtValorDepositar.Text));
                MessageBox.Show("Dinheiro Liberado !");

                MostraConta();
            }
            catch(Exception)
            {
                MessageBox.Show("Saldo Insuficiente ");
            }
        }

        public void MostraConta()
        {
            textoTitular.Text = c.Titular.Nome;
            txtNumConta.Text = Convert.ToString(c.NumeroCta);
            txtSaldo.Text = Convert.ToString(c.Saldo);
        }
    }
}
