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

namespace EJERCICIO10
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string envio;
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
            Telegram.bot.token = "646096427:AAFQ4jCcBMg0UbT7CUGoiI4W0OpTvywoeZo";

        }

        void timer_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("usuario", envio);
        }

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            //Declaracion de variables
            string nombre;
            
            //Entrada de Datos
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre:","Registro de Datos","Juan Carlos",100,0);

            MessageBox.Show("Bienvenido Usuario: " + nombre, "Sistema Administrativo",MessageBoxButton.OK,MessageBoxImage.Information);
            envio = nombre;

        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult opcion = MessageBox.Show("Realmente desea salir de la aplicación?", "Salir programa", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (opcion == MessageBoxResult.OK)
            {
                Close();
            }
        }
    }
}
