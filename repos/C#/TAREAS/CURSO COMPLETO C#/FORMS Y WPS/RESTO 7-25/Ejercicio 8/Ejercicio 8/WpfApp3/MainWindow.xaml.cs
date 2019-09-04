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
        byte temperatura;
        string clima;

        public MainWindow()
        {
            InitializeComponent();
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
            Telegram.bot.Automatic_answer.textMessage("clima", txtclima.Text);

        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            //declarar variables
            

            //entrada de datos 
            temperatura = Convert.ToByte(txtTemperatura.Text);
          

            if (temperatura< 10)
                {

                clima = "frío";

            }
            else if(temperatura>=10 && temperatura<=20)
            {

                clima = "Nublado";
            }
            else if (temperatura>20 && temperatura<=30)
            {

                clima = "Cálido";

            }
            else
                    {

                clima = "Tropical";
            }

            // salida 
            txtclima.Text = clima;
          
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtTemperatura.Clear();
        }
    }
}
