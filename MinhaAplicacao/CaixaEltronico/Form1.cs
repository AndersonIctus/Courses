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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pi = (int)3.14;

            MessageBox.Show(pi + "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 2, b = 10, c = 3;
            double delta, a1, a2;

            delta = (b * b) - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show(String.Format("A1 = {0} e A2 = {1}", a1, a2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 0;
            for(int i = 0; i < 10; i++)
            {
                total += 1;
            }

            MessageBox.Show("Total: " +  total);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total = 0, atual;
            string soma = "";
            for(int i = 0; i <= 10; i++)
            {
                atual = total;
                total += i;
                soma += atual + " + " + i + " = " + total + "\n";
                
            }
            MessageBox.Show(soma);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            long numA = 1, numB = 1, next = 0;
            string fibo = numA + ", " + numB;
            for (int i = 2; i <= 20; i++)
            {
                next = numA + numB;
                numB = numA;
                numA = next;

                //fibo += ", " + next;
            }

            MessageBox.Show("Serie 20 do fibonnacci : " + next);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string saida = "";
            for(int i = 1; i < 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    saida += (j*i) + " ";
                }

                saida += "\n";
            }

            MessageBox.Show(saida);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
