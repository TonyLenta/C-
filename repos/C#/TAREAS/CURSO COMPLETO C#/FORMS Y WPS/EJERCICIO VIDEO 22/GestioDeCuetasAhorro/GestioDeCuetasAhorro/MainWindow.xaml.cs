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

namespace GestioDeCuetasAhorro
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            desactivarControles();
        }
        private Double monto;
        private void activarControles()
        {
            txtCliente.IsEnabled = false;
            txtMonto.IsEnabled = false;
            btnAbrirCuenta.IsEnabled = false;


            btnDeposito.IsEnabled = true;
            btnRetiro.IsEnabled = true;


        }

        private void desactivarControles()
        {
            txtCliente.IsEnabled = true;
            txtMonto.IsEnabled = true;
            btnAbrirCuenta.IsEnabled = true;


            btnDeposito.IsEnabled = false;
            btnRetiro.IsEnabled = false;
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAbrirCuenta_Click(object sender, RoutedEventArgs e)
        {
            string cliente;
            //leer datos
            cliente = txtCliente.Text;
            monto = Convert.ToDouble(txtMonto.Text);
            if (monto > 0)
            {
                activarControles();
            }
            else {
                MessageBox.Show("El monot debe ser mayor o igual","Getion de ahorro",MessageBoxButton.OK,MessageBoxImage.Error);

            }

        }

        private Double leer(string mensaje)
        {
            Double cantidad;
            cantidad = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese monto a " + mensaje, "Gestion de ahorros", "0", 100, 0));
            return cantidad;
                }

        private void btnDeposito_Click(object sender, RoutedEventArgs e)
        {
            Double deposito;
            deposito = leer("Depositar");
            monto = monto + deposito;
            lstDeposito.Items.Add(deposito);

        }
        private void mostrar()
        {
            txtSaldos.Text = Convert.ToString(monto); ;
        }

        private void btnRetiro_Click(object sender, RoutedEventArgs e)
        {
            Double retiro;
            retiro = leer("Retirar");
            //evaluamos
            if (retiro <= monto)
            {
                monto = monto - retiro;
                lstRetiros.Items.Add(retiro);
                mostrar();

            }
            else
            {
                MessageBox.Show("La cantidad de reito es mayor al monto disponible","Gestion de ahorro",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtCliente.Clear();
            txtMonto.Clear();
            txtSaldos.Clear();
            lstDeposito.Items.Clear();
            lstRetiros.Items.Clear();
            desactivarControles();
        }
    }
}
