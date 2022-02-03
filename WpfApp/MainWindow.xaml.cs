using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double v1, v2, res;

        private void ClearCalculator()
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblRes.Content = "0";
            lblMultiplicador.Content = "";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtValor1.Text == "" || txtValor2.Text == "")
            {
                MessageBox.Show("Você não deve calcular valores vazios", "ATENÇÃO", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            else
            {
                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);

                res = v1 + v2;

                lblRes.Content = Convert.ToDecimal(res).ToString("0.00");
                lblMultiplicador.Content = "+";
            }


        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            if (txtValor1.Text == "" || txtValor2.Text == "")
            {
                MessageBox.Show("Você não deve calcular valores vazios");

            }
            else
            {
                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);

                res = v1 * v2;

                lblRes.Content = Convert.ToDecimal(res).ToString("0.00");
                lblMultiplicador.Content = "x";

            }

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            if (v1.ToString() == "" && v2.ToString() == "" )
            {
                MessageBox.Show("Os valores já estão limpos");
            }
            else
            {
                ClearCalculator();
            }
        }
    }
}
