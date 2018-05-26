using System;
using System.Windows.Forms;

using Caelum.CaixaEltronico.Contas;
using Caelum.CaixaEltronico.Exceptions;

namespace Caelum.CaixaEltronico
{
    public partial class MeuCaixaEltronico : Form
    {
        private Conta[] contas = new Conta[] {
            new Conta(123, "Anderson", 350.00),
            new Conta(345, "Soraya", 300.00),
            new Conta(821, "Andre", 500.00),
            new Conta(917, "Jose Aldenor", 600.00),
            new Conta(778, "Ana Celia", 500.00),
        };
        private int quantidadeDeContas;

        public MeuCaixaEltronico()
        {
            InitializeComponent();
        }

        public void AdicionaConta (Conta conta)
        {
            if(quantidadeDeContas == contas.Length)
            {
                Conta[] novo = new Conta[contas.Length * 2]; //duplica a capacidade do arrya de contas !!
                for(int i = 0; i < contas.Length; i++)
                {
                    novo[i] = contas[i];
                }

                contas = novo;
            }

            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas++;

            cbContas.Items.Add(conta);
            cbContasTranferencia.Items.Add(conta);
        }

        private void CaixaEltronico_Load(object sender, EventArgs e)
        {
            foreach (Conta c in contas)
            {
                cbContas.Items.Add(c);
                cbContasTranferencia.Items.Add(c);
            }

            this.quantidadeDeContas = contas.Length;
        }

        private void cbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbContas.SelectedIndex;
            Conta c = contas[selectedIndex];

            MostraConta(c);
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = cbContas.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Conta c = contas[selectedIndex];

                    c.Sacar(Convert.ToDouble(txtValor.Text));
                    MostraConta(c);
                }
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            int selectedIndex = cbContas.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Conta c = contas[selectedIndex];

                c.Depositar(Convert.ToDouble(txtValor.Text));
                MostraConta(c);
            }
        }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            Conta origem = SelecionaConta(cbContas);
            Conta destino = SelecionaConta(cbContasTranferencia);


            if(origem != null && destino != null)
            {
                double valor = Convert.ToDouble(txtValor.Text);
                origem.Sacar(valor);
                destino.Depositar(valor);

                MostraConta(origem);
            }
        }

        Conta SelecionaConta(ComboBox cb)
        {
            int selectedIndex = cb.SelectedIndex;
            if (selectedIndex >= 0)
            {
                return contas[selectedIndex];
            }

            return null;
        }

        void MostraConta(Conta c)
        {
            txtTitular.Text = c.Titular.Nome;
            txtNumero.Text = Convert.ToString(c.NumeroCta);
            txtSaldo.Text = Convert.ToString(c.Saldo);
        }
        
        private void btCadNovaConta_Click(object sender, EventArgs e)
        {
            CadastroDeContas formDeCadastro = new CadastroDeContas(this);
            formDeCadastro.ShowDialog();
        }
        
        private void btRemoveConta_Click(object sender, EventArgs e)
        {
            int selectedIndex = cbContas.SelectedIndex;

            cbContas.Items.Clear();
            cbContasTranferencia.Items.Clear();

            Conta[] nova = new Conta[contas.Length];
            for(int i = 0, j = 0; i < contas.Length; i++)
            {
                if (i == selectedIndex) continue;
                nova[j] = contas[i];
                j++;

                cbContas.Items.Add(nova[j]);
                cbContasTranferencia.Items.Add(nova[j]);
            }

            contas = nova;
        }
    }
}
