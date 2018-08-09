using System;
using System.Windows;

namespace Calculadora_WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>

    public partial class MainWindow : Window
    {
        double valor1 = 0;
        double valor2 = 0;
        string operador = null;
        double resultado = 0;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "0";
        }

        private void btnPonto_Click(object sender, RoutedEventArgs e)
        {

            lblCalculo.Content += ".";
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "=";
        }

        private void btnUm_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(lblCalculo.Content) == "0")
            {
                lblCalculo.Content = "1";
            }
            else
            {
                lblCalculo.Content += "1";
            }
        }
        private void btnDois_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "2";
        }
        private void btnTres_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "3";
        }

        private void btnQuatro_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "4";
        }

        private void btnCinco_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "5";
        }

        private void btnSeis_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "6";
        }

        private void btnSete_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "7";
        }

        private void btnOito_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "8";
        }

        private void btnNove_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "9";
        }

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "/";
            lblCalculo.Content = "";
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "x";
            lblCalculo.Content = "";
        }

        private void btnSubtrair_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content += "-";
            lblCalculo.Content = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblCalculo.Content = "0";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSoma_Click(object sender, RoutedEventArgs e)
        {
            if (valor1 == 0)
            {
                valor1 = Convert.ToDouble(lblCalculo.Content);
            }
            else if (valor1 != 0 && valor2 == 0)
            {
                valor2 = Convert.ToDouble(lblCalculo.Content);
            }
            if (lblResultado.ContentStringFormat.EndsWith("+"))
            {

            }
            else if (lblResultado.ContentStringFormat.EndsWith("-"))
            {
                lblResultado.Content = lblResultado.ContentStringFormat.Replace("-", "+");

            }
            else if (lblResultado.ContentStringFormat.EndsWith("x"))
            {
                lblResultado.Content = lblResultado.ContentStringFormat.Replace("x", "+");
            }
            else if (lblResultado.ContentStringFormat.EndsWith("/"))
            {
                lblResultado.Content = lblResultado.ContentStringFormat.Replace("/", "+");
            }
            else
            {
                lblResultado.Content += lblCalculo.Content + "+";
            }
            lblCalculo.Content = "0";
        }
    }
}
