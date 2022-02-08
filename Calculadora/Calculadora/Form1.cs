using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4
    }

    public partial class Calculadora : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operacion = Operacion.NoDefinida;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {

            if (Pantalla.Text == "0" && Pantalla.Text != null)
            {
                Pantalla.Text = numero;
            }
            else
            {
                Pantalla.Text += numero;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operacion)
            {

                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;

                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
            }
            return resultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LeerNumero("1");

        }

        private void button_Cero(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;
            }
            else
            {
                Pantalla.Text += "0";
            }
        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            LeerNumero("2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LeerNumero("8");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");

        }
        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(Pantalla.Text);
            lblHistorial.Text = Pantalla.Text + operador;
            Pantalla.Text = "0";
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            operacion = Operacion.Suma;
            ObtenerValor("+");          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(Pantalla.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                Pantalla.Text = Convert.ToString(resultado);
            }
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            operacion = Operacion.Resta;
            ObtenerValor("-");
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            operacion = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            operacion = Operacion.Division;
            ObtenerValor("/");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            Pantalla.Text = "0";
            lblHistorial.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length > 1)
            {
                string txtResultado = Pantalla.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length -1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    Pantalla.Text = "0";
                }

                Pantalla.Text = txtResultado;
            }
            else
            {
                Pantalla.Text = "0";
            }
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Contains("."))
            {
                return;
            }
            Pantalla.Text += ".";
        }
    }
}
