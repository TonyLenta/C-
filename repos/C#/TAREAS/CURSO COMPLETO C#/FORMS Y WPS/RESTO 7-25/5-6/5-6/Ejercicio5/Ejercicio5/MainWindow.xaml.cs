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

namespace Ejercicio5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double sueldobruto, sueldoneto, bonificacion;

        private int _numValue = 0;

        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum.Text = value.ToString();
            }

             
    }

        public MainWindow()
        {
            
            InitializeComponent();
            txtNum.Text = _numValue.ToString();

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = "682157779:AAG1uTiBzW1MQtG-J6l3BVq_kN9kGfcH0rs";
            


        }

        private void timer_Tick(object sender, EventArgs e)
        {

            Telegram.bot.update = "true";

            Telegram.bot.Automatic_answer.textMessage("sueldobruto", sueldobruto.ToString());
            Telegram.bot.Automatic_answer.textMessage("sueldoneto", sueldoneto.ToString());
            Telegram.bot.Automatic_answer.textMessage("bonificacion",bonificacion.ToString());

        }





        // ENTRADA DE DATOS 

        private void txtNum_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();
        }

        private void bntUp_Click(object sender, RoutedEventArgs e)
        {
            if (_numValue < 20)
                NumValue++;
            else MessageBox.Show("VALOR FUERA DE RANGO");
        }

        private void bntDown_Click(object sender, RoutedEventArgs e)
        {
            if (_numValue > 0)
            {
                NumValue--;
            }
            else MessageBox.Show("VALOR FUERA DE RANGO");
        }

        

        private void txtBonificacion_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        

        private void bntcalcular_Click(object sender, RoutedEventArgs e)
        {
            int Hextras, Hnormales;
            double PagoH_extra, PagoH_normales;
            int hijos;
            Boolean marcado;

            Hnormales       = Convert.ToInt32(txtHnormalesT.Text);
            Hextras         = Convert.ToInt32(txtHextrasT.Text);
            PagoH_extra     = Convert.ToDouble(txtPagoHextra.Text);
            PagoH_normales  = Convert.ToDouble(txtPagoHnormal.Text);
            hijos           = Convert.ToInt32(txtNum.Text);
            marcado = Convert.ToBoolean(chkBonificacion.IsChecked);

            bonificacion=0.0;

            sueldobruto = (Hnormales * PagoH_normales) + (Hextras * PagoH_extra);

            if (marcado = true)
            {
                bonificacion = hijos * 20;
            }

            sueldoneto = sueldobruto + bonificacion;

            txtsBruto.Text = Convert.ToString(sueldobruto);
            txtsNeto.Text = Convert.ToString(sueldoneto);
            txtBonificacion.Text = Convert.ToString(bonificacion);
            
        }

       
        private void bntnuevo_Click(object sender, RoutedEventArgs e)
        {
            txtBonificacion.Clear();
            txtHextrasT.Clear();
            txtHnormalesT.Clear();
            txtNum.Clear();
            txtsBruto.Clear();
            txtsNeto.Clear();
            txtPagoHextra.Clear();
            txtPagoHnormal.Clear();
            chkBonificacion.IsChecked = false;
            
        }

        private void bntsalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       


    }


}
