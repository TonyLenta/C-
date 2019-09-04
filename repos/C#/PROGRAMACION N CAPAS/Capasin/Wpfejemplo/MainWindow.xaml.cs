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
using EN;
using BL;

namespace Wpfejemplo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ventas _en = new Ventas();// objetos que llaman a  las otras capas
        VentasBL _bl = new VentasBL();// objeto que llamas a las otras capas bl
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtVentas.Text = string.Empty;
            txtEstado.Text = string.Empty;
            
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtVentas.Text == "" || txtEstado.Text == "")
                {
                    MessageBox.Show("Hay espacios en blanco", "Alerta", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    _en.Nombre = txtNombre.Text;
                    _en.TotalVentas = Convert.ToInt64(txtVentas.Text);
                    _en.Estado = txtEstado.Text;
                    int Resultado = _bl.AgregarVentas(_en);
                    if (Resultado == 1)
                    {
                        MessageBox.Show("Los datos se guardaron corretamente...", "Exito!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                        Limpiar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error...", "Error!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {

            Limpiar();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            Consulta _ver = new Consulta();
            this.Close();
            _ver.ShowDialog();
        }
    }
}
