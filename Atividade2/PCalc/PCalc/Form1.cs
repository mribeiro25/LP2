using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Você realmente deseja sair?", "Saída",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question)==
               DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            try
            {
                errorProvider2.SetError(txtNumero2, "");
                numero2 = Convert.ToDouble(txtNumero2.Text);
            }
            catch (Exception)
            {
                errorProvider2.SetError(txtNumero2, "Número 2 inválido");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if(!Double.TryParse(txtNumero1.Text, out numero1) ||
               !Double.TryParse(txtNumero2.Text, out numero2))
            {
                txtNumero1.Focus();
            }
            else
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if (!Double.TryParse(txtNumero1.Text, out numero1) ||
               !Double.TryParse(txtNumero2.Text, out numero2))
            {
                txtNumero1.Focus();
            }
            else
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if (!Double.TryParse(txtNumero1.Text, out numero1) ||
               !Double.TryParse(txtNumero2.Text, out numero2))
            {
                txtNumero1.Focus();
            }
            else
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            if (!Double.TryParse(txtNumero1.Text, out numero1) ||
               !Double.TryParse(txtNumero2.Text, out numero2))
            {
                txtNumero1.Focus();
            }
            else
            {
                if(numero2 == 0)
                {
                    errorProvider2.SetError(txtNumero2, "Número 2 não pode ser 0");
                    txtNumero2.Focus();
                }
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text, out numero1))
            {
                errorProvider1.SetError(txtNumero1, "Número 1 inválido");
            }
            else
                errorProvider1.SetError(txtNumero1, "");
        }
    }
}
