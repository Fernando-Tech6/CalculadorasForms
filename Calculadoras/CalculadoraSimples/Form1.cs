using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        double primeiroNumero;
        double segundoNumero;
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Resetar()  // Criando metodo para limpar todos os txtBox
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
        }
        private void Atribuicao()
        {   // Para não ficar repetindo em cada button.
            primeiroNumero = Convert.ToDouble(txtNum1.Text);
            segundoNumero = Convert.ToDouble(txtNum2.Text);
        }
        private void BtnSomar_Click(object sender, EventArgs e)
        {
            /* Utilizando try catch para possibilidade de digitarem letras ou
            simbolos com o metodo Resetar ao final para limpar o txtBox */

            try
            {
                Atribuicao();
                resultado = primeiroNumero + segundoNumero;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas numeros", "Alerta", MessageBoxButtons.OK);
                Resetar();
            }
            
        }

        private void BtnDiminuir_Click(object sender, EventArgs e)
        {
            try
            {
                Atribuicao();
                resultado = primeiroNumero - segundoNumero;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas numeros", "Alerta", MessageBoxButtons.OK);
                Resetar();
            }
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Atribuicao();
                resultado = primeiroNumero * segundoNumero;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas numeros","Alerta",MessageBoxButtons.OK);
                Resetar();
            }
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                Atribuicao();
                resultado = primeiroNumero / segundoNumero;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas numeros", "Alerta", MessageBoxButtons.OK);
                Resetar();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Resetar();            
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
