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

namespace WpfApp7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double suma, resta, mult, div;
        double i;
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
            Telegram.bot.token = "682157779:AAG1uTiBzW1MQtG-J6l3BVq_kN9kGfcH0rs";
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("suma", suma.ToString());
            Telegram.bot.Automatic_answer.textMessage("resta", resta.ToString());
            Telegram.bot.Automatic_answer.textMessage("multiplicacion", mult.ToString());
            Telegram.bot.Automatic_answer.textMessage("division", div.ToString());
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            //Declaración de variables
            int numero;
            
            //Entrada de datos
            numero = Convert.ToInt32(txtnumero.Text);
            //Proceso
            //Dejamos en blanco lo combobox
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();
            // Creamos nuestro bucle para poder mostrar la tabla del 1 al                 12

            for (int i = 1; i <= 12; i = i + 1)
            {
                suma = numero + i;
                resta = numero - i;
                mult = numero * i;
                div = numero / i;
                //Agregar los resultados a los combobox
                cbosuma.Items.Add(numero + " + " + i + " = " + suma);
                cboresta.Items.Add(numero + " - " + i + " = " + resta);
                cbomult.Items.Add(numero + " * " + i + " = " + mult);
                cbodiv.Items.Add(numero + " / " + i + " = " + div);



            }
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();
            txtnumero.Clear();
        }
    }
}
