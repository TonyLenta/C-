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
using Clases;
// para enviar por telegram
using System.Runtime;
using System.Windows.Threading;


using System.IO; //controla crea archivos


using System.Web;

namespace EJERCICIO24
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Filas fila = new Filas();
        List<Filas> filas = new List<Filas>();
        string TOKEN = "611239617:AAFnr9iCPlzXvNdFoI8GaUmGiUWUv42eyVc";
        public MainWindow()
        {
            //timer 
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            //timer.Tick += timer_Tick;
            timer.Start();

            InitializeComponent();
            //telegram 
            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = TOKEN;
            InitializeComponent();

            fila.Tipo = "Tipo";
            fila.Apellidos = "Apellidos";
            fila.Nombres = "Nombres";
            fila.Documento = "Documento";
            fila.Sueldo = "Sueldo";
        }

        public class Filas
        {
            public string Tipo { set; get; }
            public string Apellidos { set; get; }
            public string Nombres { set; get; }
            public string Documento { set; get; }
            public string Sueldo { set; get; }
        }
        
        private void dtClockTime_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("Nombre", txtNombres.ToString());
            


        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //agregando token a al xamp
            if (cboTipo.Text== "Prueba")
            {
                txtToken.Text = TOKEN;
            }


            Vendedor vendedor1 = new Vendedor();
            vendedor1.Apellidos = txtApellidos.Text;
            vendedor1.Nombres = txtNombres.Text;
            vendedor1.Documento = txtDocumento.Text;
            vendedor1.Tipo = cboTipo.Text;
            vendedor1.TipoContrato = cboTipoContrato.Text;

            vendedor1.calcularSueldo(750);

            //AÑADIR FILA
            

            fila = new Filas();
            fila.Tipo = vendedor1.Tipo;
            fila.Apellidos = vendedor1.Apellidos;
            fila.Nombres = vendedor1.Nombres;
            fila.Documento = vendedor1.Documento;
            fila.Sueldo = vendedor1.Sueldo.ToString();
            filas.Add(fila);
            dgvVendedores.Items.Add(fila);

            //dgvVendedores.(0, vendedor1.Tipo, vendedor1.Apellidos, vendedor1.Nombres, vendedor1.Documento, vendedor1.Sueldo);

        }

        private void DataGridTextColumn_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtApellidos.Clear();
            txtDocumento.Clear();
            txtNombres.Clear();
            cboTipo.Text = "";
            cboTipoContrato.Text = "";
        }

       
    }
}
