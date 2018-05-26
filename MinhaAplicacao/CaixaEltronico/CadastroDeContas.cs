using Caelum.CaixaEltronico.Contas;
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
    public partial class CadastroDeContas : Form
    {
        private MeuCaixaEltronico appPrincipal;
        private string[] tipoContas = new string[] {
            "001 - Conta Corrente",
            "013 - Conta Poupança",
        };

        public CadastroDeContas(MeuCaixaEltronico appPrincipal)
        {
            InitializeComponent();
            this.appPrincipal = appPrincipal;
        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            foreach (string tp in tipoContas)
            {
                cbTipoConta.Items.Add(tp);
            }
        }

        private void btNovaConta_Click(object sender, EventArgs e)
        {
            int numConta = Convert.ToInt32(txtNumConta.Text);

            int selectedIndex = cbTipoConta.SelectedIndex;
            Conta conta = null;
            switch (selectedIndex)
            {                
                case 0: conta = new ContaCorrente(numConta, txtTitularConta.Text); break;

                default:
                case 1: conta = new ContaPoupanca(numConta, txtTitularConta.Text); break;
            }
            
            appPrincipal.AdicionaConta(conta);

            MessageBox.Show("Conta Cadastrada !!");
            this.Dispose();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
