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

namespace WpfApp3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rtgCuadrado.Visibility =  Visibility.Hidden;
            rtgRectangulo.Visibility = Visibility.Hidden;

        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            //ENTRADA
            //DECLARACION DE VARIABLES

            byte ladA, ladB;
            double area, perimtr;

            //asignacion
            ladA = Convert.ToByte(txtladoa.Text);
            ladB = Convert.ToByte(txtladob.Text);




            //PROCESO
            //condificon logica
            if (ladA == ladB)
            {
                rtgCuadrado.Visibility = Visibility.Visible;
                rtgRectangulo.Visibility = Visibility.Hidden;
            }
            else {

                rtgCuadrado.Visibility = Visibility.Hidden;
                rtgRectangulo.Visibility = Visibility.Visible;
            }
            area = ladA*ladB;
            perimtr =2*(ladA+ladB);

            //SALIDA
            txtArea.Text = Convert.ToString(area);
            txtPerimetro.Text =Convert.ToString( perimtr);
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtArea.Clear();
            txtPerimetro.Clear();
            txtladoa.Clear();
            txtladob.Clear();
            rtgCuadrado.Visibility = Visibility.Hidden;
            rtgRectangulo.Visibility = Visibility.Hidden;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); ;
        }
    }
}
