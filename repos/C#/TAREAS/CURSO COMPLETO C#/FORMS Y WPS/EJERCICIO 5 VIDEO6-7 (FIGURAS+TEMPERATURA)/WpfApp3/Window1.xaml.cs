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

namespace WpfApp3
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
            //Entrada
            //Declaracion de variables
            byte temperatura;
            string clima;
            //asignacion
            temperatura = Convert.ToByte(txtTemperatura.Text);



            //procese
            if (temperatura > 0 && temperatura < 10)
            {
                clima = "frio";
            }
            else if (temperatura >= 10 && temperatura <= 20)
            {
                clima = "nublado";

            }
            else if (temperatura >= 21 && temperatura <= 30)
            {
                clima = "calor";

            }
            else {
                clima = "tropical";
            }



            //salida
            txtClima.Text = clima;



        }
    }
}
