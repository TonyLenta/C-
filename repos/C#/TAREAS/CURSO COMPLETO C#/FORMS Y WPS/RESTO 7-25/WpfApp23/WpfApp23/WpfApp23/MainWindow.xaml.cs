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

namespace WpfApp23
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            Telegram.bot.token = "665028445:AAFaoOd32thQcqAaU1bFIq5dym4H8dQJzVs";

        }

        void timer_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("U", txtResultado.Text);
        }
        private void btnObjeto1_Click(object sender, RoutedEventArgs e)
        {
            Perro perrito = new Perro();
            perrito.Nombre = "Zeus";
            perrito.Raza = "Golden Retriever";
            perrito.Altura = "0.75";

            txtResultado.Text=perrito.comer("Carne");


        }

        private void btnObjeto2_Click(object sender, RoutedEventArgs e)
        {
            Perro perrito = new Perro();
            perrito.Nombre = "Jeyko";
            perrito.Raza = "Pastor Aleman";
            perrito.Altura = "0.80";

            txtResultado.Text = perrito.comer("Pollo");

        }

        private void btnObjeto3_Click(object sender, RoutedEventArgs e)
        {
            Perro perrito = new Perro("Sami", "Poodle", "0.40");
            txtResultado.Text = perrito.comer("Pan");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
