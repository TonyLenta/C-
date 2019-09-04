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

namespace ejercicio15
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        double t;
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
            Telegram.bot.token = "692303727:AAFoDACSCWl1rfkRVijymyWJteeOy-qUN6g";
        }
        void timer_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("1",t.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Declaracion de variables 
            int cantAlumnos, nota;
            double promedio = 0;
            // Entrada de datos 
            cantAlumnos = Convert.ToInt32(text1.Text);
            // proceso
            // implementar un bucle para pedir la nota de los alumnos
            for(int i=1;i<= cantAlumnos; i++)
            {
                // leer la nota del al alumno n
                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("ingrese nota del alumno" + i, "Registro de notas"));
                } while (nota < 0 || nota > 20);
                promedio = promedio + nota;
                t = promedio / cantAlumnos;
            }
            //SALIDA DE INFORMACION
            text2.Text = Convert.ToString(t);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text1.Clear();
            text2.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
