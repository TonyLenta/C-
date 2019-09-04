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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte numero;
        string dia;
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
            Telegram.bot.token = "662095602:AAExWmOYlhiyO9DEgtw38ZkoI-aMAfw_LaA";
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("dia", txtdia.Text);
           
        } 

        //"662095602:AAExWmOYlhiyO9DEgtw38ZkoI-aMAfw_LaA"
        // 0

            
        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            //asignacion de datos
          

            //entrada de datos
            numero = Convert.ToByte(txtnumero.Text);

            switch(numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miércoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Error ingrese otro número";
                break;
            }
            //resultados
            txtdia.Text = dia;
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            txtdia.Clear();
            txtnumero.Clear();
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

}
