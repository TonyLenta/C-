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

namespace array
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            //declaracion de variables
            double[] vGastos;
            double gasto, totalGasto, diaMayor, gastoMayor;
            int cantDias;
            //Inicializar
            totalGasto = 0;
            diaMayor = 1;
            gastoMayor = 0;
            //Leida de datos
            cantDias = Convert.ToInt32(txtCantidadDias.Text);
            vGastos = new double[cantDias];
            for (int dia = 1; dia <= cantDias; dia = dia + 1)
            {
                gasto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el gasto del dia " + dia, "gastos"));
                vGastos[dia - 1] = gasto;
            }
            for (int i = 0; i < cantDias; i++)
            {
                //Evaluamos el gato mayor
                if (vGastos[i] > gastoMayor)
                {
                    gastoMayor = vGastos[i];
                    diaMayor = i + 1;
                }
                //Calcular el total
                totalGasto = totalGasto + vGastos[i];
                //mostrar los gastos en el combobox
                cmbGastos.Items.Add("Dias" + (i + 1) + "Total:" + vGastos[i]);
            }

            //Mostrar la informacion
            txtGastomayor.Text = Convert.ToString(gastoMayor);
            txtdiamayor.Text = Convert.ToString(diaMayor);
            txtTotaslGastos.Text = Convert.ToString(totalGasto);
        }

        private void btnNuevo2_Click(object sender, RoutedEventArgs e)
        {
            txtCantidadDias.Clear();
            txtdiamayor.Clear();
            txtGastomayor.Clear();
            txtTotaslGastos.Clear();
            cmbGastos.Items.Clear();
        }

        private void btnSalir2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
