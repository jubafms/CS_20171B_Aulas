using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        float valor1 = 0;
        float valor2 = 0;
        float resultado = 0;
        String operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbvisor.Text = "";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "4";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbvisor.Text = tbvisor.Text + "1";
        }

        private void btnadição_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(tbvisor.Text);
            tbvisor.Text = "";
            operacao = "+";
             
        }

        private void btnigual_Click(object sender, EventArgs e)
        {

            valor2 = float.Parse(tbvisor.Text);
            tbvisor.Text = "";

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    tbvisor.Text = string.Format("{0:G}", resultado);
                    break;

                case "-":
                    resultado = valor1 - valor2;
                    tbvisor.Text = string.Format("{0:G}", resultado);
                    break;

                case "*":
                    resultado = valor1 * valor2;
                    tbvisor.Text = string.Format("{0:G}", resultado);
                    break;

                case "/":
                    resultado = valor1 / valor2;
                    tbvisor.Text = string.Format("{0:G}", resultado);
                    break;

                case "p":
                    resultado = 0;
                    float aux = valor1;
                    for( int i = 1; i < valor2; i++ )
                    {
                        resultado = aux * valor1;
                        aux = resultado;
                    }
                    tbvisor.Text = string.Format("{0:G}", resultado);
                    break;


                  }

               
                
 }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(tbvisor.Text);
            tbvisor.Text = "";
            operacao = "-";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(tbvisor.Text);
            tbvisor.Text = "";
            operacao = "*";
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(tbvisor.Text);
            tbvisor.Text = "";
            operacao = "/";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            valor1 = float.Parse(tbvisor.Text);
            tbvisor.Text = "";
            operacao = "r";

        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(tbvisor.Text);
            tbvisor.Text = "";
            operacao = "p";

        }
    }
}
