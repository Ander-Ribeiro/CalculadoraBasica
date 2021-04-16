using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        { 
            //Declaração da variavel tipo Double
            double num1, num2, resultado;
            /*num1 e 2 recebe o conteudo da textBox
            (txtNum1 e txtNum2)*/
            
            /*O Convert.ToDouble é necessário
              para converter o conteúdo do textBox 
             em número*/
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 + num2;
            
            /* o txtResultado.Text recebe o contéudo da variavel
             resultado, e converte em número*/

            txtResultado.Text = resultado.ToString();


        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            //Declaração da variavel tipo Double
            double num1, num2, resultado;
            /*num1 e 2 recebe o conteudo da textBox
            (txtNum1 e txtNum2)*/

            /*O Convert.ToDouble é necessário
              para converter o conteúdo do textBox 
             em número*/
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 - num2;

            /* o txtResultado.Text recebe o contéudo da variavel
             resultado, e converte em número*/

            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Declaração da variavel tipo Double
            double num1, num2, resultado;
            /*num1 e 2 recebe o conteudo da textBox
            (txtNum1 e txtNum2)*/

            /*O Convert.ToDouble é necessário
              para converter o conteúdo do textBox 
             em número*/
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 * num2;

            /* o txtResultado.Text recebe o contéudo da variavel
             resultado, e converte em número*/

            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //Declaração da variavel tipo Double
            double num1, num2, resultado;
            /*num1 e 2 recebe o conteudo da textBox
            (txtNum1 e txtNum2)*/

            /*O Convert.ToDouble é necessário
              para converter o conteúdo do textBox 
             em número*/
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 / num2;

            /* o txtResultado.Text recebe o contéudo da variavel
             resultado, e converte em número*/

            txtResultado.Text = resultado.ToString();
        }
    }
}
