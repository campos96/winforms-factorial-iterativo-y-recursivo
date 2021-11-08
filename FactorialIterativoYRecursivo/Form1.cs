using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialIterativoYRecursivo
{
    public partial class Form1 : Form
    {
        private Int32 Numero = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecursivo_Click(object sender, EventArgs e)
        {
            if (IsValidInt(txtNumero.Text))
            {
                txtResultado.Text = ObteberFactorialIterativo(Numero).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido!");
            }
        }

        private void btnIterativo_Click(object sender, EventArgs e)
        {
            if (IsValidInt(txtNumero.Text))
            {
                txtResultado.Text = ObteberFactorialRecursivo(Numero).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido!");
            }
        }

        private bool IsValidInt(string numero)
        {
            return Int32.TryParse(numero, out Numero);
        }

        private Int32 ObteberFactorialRecursivo(Int32 numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * ObteberFactorialRecursivo(--numero);
            }
        }

        private Int32 ObteberFactorialIterativo(Int32 numero)
        {
            if (numero == 0 )
            {
                return 1;
            }
            var resultado = numero;
            for (Int32 i = numero - 1; i > 0; i--)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
