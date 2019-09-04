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

namespace Ejercicio9Wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declarar de manera golbar el segundo timer

        System.Windows.Threading.DispatcherTimer yolo = new System.Windows.Threading.DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            //Timer
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer1_Tick;
            timer.Start();

            lblhora.Text = DateTime.Now.ToLongTimeString();

            
            yolo.Interval = TimeSpan.FromSeconds(1);
            yolo.Tick += timer2_Tick;
            yolo.Start();

            yolo.IsEnabled = false;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private int num = 0;

        void timer2_Tick(object sender, EventArgs e)
        {
            num = num +1;
            if(num % 2 ==0)
            {
                lbla.Visibility = Visibility.Visible;
                lblb.Visibility = Visibility.Hidden;
            }
            else
            {
                lbla.Visibility = Visibility.Hidden;
                lblb.Visibility = Visibility.Visible;
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            yolo.IsEnabled = true;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            yolo.IsEnabled = false;
        }
    }
}
