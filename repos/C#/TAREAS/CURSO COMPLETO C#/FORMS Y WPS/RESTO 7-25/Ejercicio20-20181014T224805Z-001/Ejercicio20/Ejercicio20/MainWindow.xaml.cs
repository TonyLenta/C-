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

namespace Ejercicio20
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer dtClockTime = new DispatcherTimer();
            dtClockTime.Interval = new TimeSpan(0, 0, 10); //in Hour, Minutes, Second.
            dtClockTime.Tick += dtClockTime_Tick;
            dtClockTime.Start();
            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = "698262443:AAH8IwWJR97VmW6TTqNtHD-X0crc5OGvTuI";
        }
        private void dtClockTime_Tick(object sender, EventArgs e)
        {
            
           // Telegram.bot.update = "true";
           // Telegram.bot.Automatic_answer.textMessage("suma", cadena.Length.ToString());
        }

        private void btnProcesar_Click(object sender, RoutedEventArgs e)
        {
            //Declarar las variables
            string cadena = txtCadena.Text;
            //Aplicar las funciones 
            //Calculamos la longitud de la cadena
            txtLongitud.Text = Convert.ToString(cadena.Length);
            //Mostrar en primer caracter 
            txtPrimer.Text = cadena.Substring(0, 1);
            //MOstrar el ultimo caracter
            txtUltimo.Text = cadena.Substring(cadena.Length - 1, 1);
            //Mostrar del segundo al sexto caracter
            txt26.Text = cadena.Substring(1, 5);
            //Buscamos la ubicacion de la primera letra A 
            txtA.Text = Convert.ToString(cadena.IndexOf("A", 0) + 1);
            //Convertimos las letras mayuscula
            txtMayusculas.Text = cadena.ToUpper();
            //Convertimos las letras minusculas
            txtMinusculas.Text = cadena.ToLower();
            //Borrar los espacios en blanco 
            txtBorrarEspacios.Text = cadena.Replace(" ", "");

            //Salida de informacion
            txtCadena.Text = cadena;
            txtLongitud.Text = Convert.ToString(cadena.Length);
            txtPrimer.Text = Convert.ToString(cadena.Substring(0, 1));
            txtUltimo.Text = Convert.ToString(cadena.Substring(cadena.Length - 1, 1));
            txt26.Text = Convert.ToString(cadena.Substring(1, 5));
            txtA.Text = Convert.ToString(cadena.IndexOf("A", 0) + 1);
            txtMayusculas.Text = Convert.ToString(cadena.ToUpper());
            txtMinusculas.Text = Convert.ToString(cadena.ToLower());
            txtBorrarEspacios.Text = Convert.ToString(cadena.Replace(" ", ""));
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("Cadena", "" + "  " + cadena);
            Telegram.bot.Automatic_answer.textMessage("Longitud", cadena.Length.ToString());
            Telegram.bot.Automatic_answer.textMessage("Primer Caracter", (cadena.Substring(0, 1)).ToString());
            Telegram.bot.Automatic_answer.textMessage("Ultimo Caracter", (cadena.Substring(cadena.Length - 1, 1)).ToString());
            Telegram.bot.Automatic_answer.textMessage("Segundo al sexto caracter", (cadena.Substring(1, 5)).ToString());
            Telegram.bot.Automatic_answer.textMessage("Posicion A", (cadena.IndexOf("A", 0) + 1).ToString());
            Telegram.bot.Automatic_answer.textMessage("Mayusculas", (cadena.ToUpper()).ToString());
            Telegram.bot.Automatic_answer.textMessage("Minusculas", (cadena.ToLower()).ToString());
            Telegram.bot.Automatic_answer.textMessage("Borrar espacios", (cadena.Replace(" ","")).ToString());
           
        }

        private string Substring()
        {
            throw new NotImplementedException();
            

        }
    }
}
