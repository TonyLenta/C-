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


namespace Ejercicio_6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double area, perimetro;

        public MainWindow()
        {
            InitializeComponent();


            rtgcuadrado.Visibility = Visibility.Visible;
            rtgrectangulo.Visibility = Visibility.Visible;
            rtgrectangulo.Visibility = Visibility.Hidden;
            rtgcuadrado.Visibility = Visibility.Hidden;




            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = "682157779:AAG1uTiBzW1MQtG-J6l3BVq_kN9kGfcH0rs";
           

        }

        void timer_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";

            Telegram.bot.Automatic_answer.textMessage("area",area.ToString());
            Telegram.bot.Automatic_answer.textMessage("perimetro", perimetro.ToString());
        }

        private void WindowsFormsHost_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            txtarea.Clear();
            txtlado_a.Clear();
            txtlado_b.Clear();
            txtperimetro.Clear();
            rtgcuadrado.Visibility = Visibility.Visible;
            rtgrectangulo.Visibility = Visibility.Visible;
            rtgrectangulo.Visibility = Visibility.Hidden;
            rtgcuadrado.Visibility = Visibility.Hidden;

        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            double ladoA, ladoB;

            ladoA = Convert.ToDouble(txtlado_a.Text);
            ladoB = Convert.ToDouble(txtlado_b.Text);



            // proceso 
            area = ladoA * ladoB;
            perimetro = 2 * (ladoA + ladoB);

            if (ladoA == ladoB)
            {

                rtgcuadrado.Visibility = Visibility.Visible;
            }
            else
            {

                rtgrectangulo.Visibility = Visibility.Visible;
            }

            txtarea.Text = Convert.ToString(area);
            txtperimetro.Text = Convert.ToString(perimetro);
        }

    }
}