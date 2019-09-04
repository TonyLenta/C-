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

namespace Arrays
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double promedio;

        public MainWindow()
        {
            InitializeComponent();
            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = "618988831:AAEJx8odRQfpONKsTqbe1ilLo9ISb9BSO30";
        }

        private void btnCargarVector_Click(object sender, RoutedEventArgs e)
        {
            //declaracion de variables
            int[] notas = new int[5];
            // espesificar  notas

            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;

            int suma = 0;
            

            //proceso

            cboNotas.Items.Clear();

            // Recorrer el vector
            for(int  i = 0 ; i<=4; i++)
            {
                //mostrar las notas en el combobox

                cboNotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 5;

            // salida de informacion

            txtPromedio.Text = Convert.ToString(promedio);

        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtPromedio.Clear();
            cboNotas.Items.Clear();

        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("promedio",txtPromedio.ToString());
        }
    }
}
