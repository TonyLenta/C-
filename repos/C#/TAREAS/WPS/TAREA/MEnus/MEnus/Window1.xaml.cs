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
using System.Windows.Shapes;

namespace MEnus
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            // declaramos variables 
            int num1, num2, resul;


            if (string.IsNullOrEmpty(txtNum1.Text))
            {
                MessageBox.Show("Debe completar la informacion");
            }
            else
            {
                //concvertimos
                num1 = Convert.ToInt32(txtNum1.Text);
                num2 = Convert.ToInt32(txtNum1.Text);

                //calculamos
                resul = num1 + num2;

                //salida
                txtResultado.Text = Convert.ToString(resul);

            }


        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        
        }
    }
}
