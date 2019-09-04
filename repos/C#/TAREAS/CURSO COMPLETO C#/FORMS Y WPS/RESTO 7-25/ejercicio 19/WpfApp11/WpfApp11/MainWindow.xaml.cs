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

namespace WpfApp11
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            vender.IsEnabled = false;
            text3.IsEnabled = true;
            text4.IsEnabled = false;
            //Timer
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            Telegram.bot.token = "646096427:AAFQ4jCcBMg0UbT7CUGoiI4W0OpTvywoeZo";
            Telegram.bot bot = new Telegram.bot();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            
            Telegram.bot.Automatic_answer.textMessage("4", text3.Text);
        }
        // declaracion de variables
        private string[,] mPlatos;
        private int cantPlatos;
        private int index;
        private int encuentra = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cantPlatos = Convert.ToInt32(text1.Text);
            // inciacializar la matriz
            mPlatos = new string[cantPlatos, 3];
            // ingresar datos a nuestra matriz
            for (int i = 0; i < cantPlatos; i++)
            {
                mPlatos[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("ingrese el nombre del plato" + (i + 1), "Restaurant");
                mPlatos[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Precio del plato " + (i + 1), "Restaurant");
                mPlatos[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad disponible del plato " + (i + 1), "Restaurant");
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Declaración de variables
            string plato;
            //Entrada de Datos
            plato = text2.Text;
            //Filtramos el plato en la matriz
            for (int i = 0; i < cantPlatos; i++)
            {
                if (mPlatos[i, 0].Equals(plato))
                {
                    text3.Text = mPlatos[i, 1];
                    text4.Text = mPlatos[i, 2];
                    index = i;
                    vender.IsEnabled = true;
                    encuentra = 1;

                }

            }
            if (encuentra == 0)
            {
                MessageBox.Show("No existe el plato", "Restaurant", MessageBoxButton.OK, MessageBoxImage.Error);
                vender.IsEnabled = false;
            }
        }

        private void vender_Click(object sender, RoutedEventArgs e)
        {
            //Declaración de variables
            int cant, stock;
            //Entrada de Datos
            cant = Convert.ToInt32(text1.Text);
            stock = Convert.ToInt32(text4.Text);

            if (cant <= stock)
            {
                //Disminuimos el stock de ese plato
                mPlatos[index, 2] = Convert.ToString(stock - cant);
            }
            else
            {
                MessageBox.Show("No hay suficiente Stock", "Restaurant", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            }
        }
    }

}
