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

        private void Atribuicao()
        {
            primeiroNumero = Convert.ToDouble(txtNum1.Text);
            segundoNumero = Convert.ToDouble(txtNum2.Text);
        }
        private void BtnSomar_Click(object sender, EventArgs e)
        {
            Atribuicao();
            resultado = primeiroNumero + segundoNumero;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnDiminuir_Click(object sender, EventArgs e)
        {
            Atribuicao();
            resultado = primeiroNumero - segundoNumero;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            Atribuicao();
            resultado = primeiroNumero * segundoNumero;
            txtResultado.Text = resultado.ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            Atribuicao();
            resultado = primeiroNumero / segundoNumero;
            txtResultado.Text = resultado.ToString();
        }
    }
}
