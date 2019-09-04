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

namespace Vacunas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int stockInicial;
        public MainWindow()
        {
            InitializeComponent();
            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = "618988831:AAEJx8odRQfpONKsTqbe1ilLo9ISb9BSO30";
        }
                
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            //Declaración de variables
            
            int cantPersonas, cantEntrega;
            //Entrada de datos
            stockInicial = Convert.ToInt32(txtStockI.Text);
            cantPersonas = 0;


            //empezamos a repartir las vacunas
            while (stockInicial >= 10)
            {
                cantEntrega = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad de la persona" + (cantPersonas + 1) + "Stock Actual: " + stockInicial, "Reparto de vacunas"));
                //validamos que la cantidad sea menor que el stock
                if (stockInicial >= cantEntrega)
                {
                    cantPersonas = cantPersonas + 1;
                    stockInicial = stockInicial - cantEntrega;
                }
                else
                {
                    MessageBox.Show("No hay Stock suficiente", "Reparto Vacunas", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
            MessageBox.Show("El Stock es inferior a 10 und", "Reparto Vacunas",MessageBoxButton.OK, MessageBoxImage.Information);

            //Salida de Información
            txtStock.Text = Convert.ToString(stockInicial);
            txtCantidad.Text = Convert.ToString(cantPersonas);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtStockI.Clear();
            txtCantidad.Clear();
            txtStock.Clear();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("stock", txtStock.ToString());
        }
    }
}

