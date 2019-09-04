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

namespace Ejercicio14Wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double notabaja, promedio;
        public MainWindow()
        {
            InitializeComponent();
            //Timer
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            //Telegram
            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = "647839454:AAGx6SM_BevPQtZZ5JOPG904SWIJQWJdmvc";
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("promedio", promedio.ToString());
            Telegram.bot.Automatic_answer.textMessage("notabaja", notabaja.ToString());
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtNumero.Clear();
            txtNotaBaja.Clear();
            txtPromedio.Clear();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            // Declaracion
            int numalumnos;
            double nota, sumanotas;
            if (txtNumero.Text!="")
            {
                // Entrada de datos
                numalumnos =Convert.ToInt32( txtNumero.Text);
                // Inicializar las variables
                sumanotas = 0.0;
                notabaja = 20.0;

                for (int i=1; i<=numalumnos; i=i+1)
                {
                    nota = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del Alumno" + i, "Promedio Notas", "16", 100, 100));
                    sumanotas = sumanotas + nota;
                    if (nota<notabaja)
                    {
                        notabaja = nota;
                    }
                }
                promedio = sumanotas / numalumnos;

                // Salida de Informacion
                txtPromedio.Text = Convert.ToString(promedio);
                txtNotaBaja.Text = Convert.ToString(notabaja);
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido", "Promedio Notas", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
