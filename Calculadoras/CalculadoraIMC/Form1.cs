using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {   // Para Limpar todo conteudo do txtBox.
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtImc.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // O calculo do IMC é: peso(kg) / quadrado da altura (metros).
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);

            double Imc = peso / Math.Pow(altura, 2);

            txtImc.Text = Imc.ToString("N2");   // resultado sendo exibido no txtbox e com apenas dois digitos apos a virgula.

            //Seguindo a tabela proposta no site.
            //https://bvsms.saude.gov.br/bvs/dicas/215_obesidade.html

            if (Imc < 18.5)
            {
                MessageBox.Show("Você está abaixo do peso", "Mensagem", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Imc <= 24.9)
            {
                MessageBox.Show("Seu peso está normal", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Imc <= 29.9)
            {
                MessageBox.Show("Você está acima do peso", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Imc <= 34.9)
            {
                MessageBox.Show("Acima do peso (Obesidade Grau I)", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Imc <= 39.9)
            {
                MessageBox.Show("Acima do peso (Obesidade Grau II)", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Imc > 40.0)
            {
                MessageBox.Show("Acima do peso (Obesidade Grau II)", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }
    }
}
