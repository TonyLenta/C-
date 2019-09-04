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
namespace ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            DispatcherTimer dtClockTime = new DispatcherTimer();
            dtClockTime.Interval = new TimeSpan(0, 0, 10); //in Hour, Minutes, Second.
            dtClockTime.Tick += dtClockTime_Tick;
            dtClockTime.Start();
            Telegram.bot.token = "698262443:AAH8IwWJR97VmW6TTqNtHD-X0crc5OGvTuI";
        }
        private void dtClockTime_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiar();


        }
        private void limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
            int numero1;
            int numero2;
            //entrada de datos
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);
            //declarar la variable suma
            int suma;
            suma = sumar(numero1, numero2);
            txtResultado.Text = Convert.ToString(suma);
            //salida
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("suma", suma.ToString());

        }
        private int sumar(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;
            return resultado;
        }
        private Double operaciones (int num1, int num2, string op)
        {
            Double resultado;
            if (op == "s")
            {
                resultado = num1 + num2;
            }
            else if (op == "r")
            {
                resultado = num1 - num2;
            }
            else if (op == "m")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

        private void btnRestar_Click(object sender, RoutedEventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;
            //entrada de datos
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);
            //Llamar a la operacion
            resultado = operaciones(numero1, numero2, "r");
            //mostar informacion
            txtResultado.Text = Convert.ToString(resultado);
            //salida
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("resta", resultado.ToString());
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;
            //entrada de datos
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);
            //Llamar a la operacion
            resultado = operaciones(numero1, numero2, "m");
            //mostar informacion
            txtResultado.Text = Convert.ToString(resultado);
            //salida
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("multiplicacion", resultado.ToString());
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;
            //entrada de datos
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);
            //Llamar a la operacion
            resultado = operaciones(numero1, numero2, "d");
            //mostar informacion
            txtResultado.Text = Convert.ToString(resultado);
            //salida
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("division", resultado.ToString());
        }
    }
}
