using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double monto,total;
        public Form1()
        {
            InitializeComponent();
            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = "518734437:AAEkIa9pvZ6a2ytyjOPHDwvUbH1mz4MNMpQ";
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //declaracion
            //declaracion de variables
            double capital, razon,tiempo; //delcaro la variable para txtcapital, operadores
            

            //Entrada
            //ingreso de variables

            capital = Convert.ToDouble(textCapital.Text);
            razon = Convert.ToDouble(textRazon.Text);
            tiempo = Convert.ToDouble(textTiempo.Text);

            //Proceso
            //operaciones
                       
             monto= Math.Pow((1+razon), tiempo)*capital;
             total = monto-capital;

            //salida
            //resultados
            //convertimos los numero ingresado en el texto a numeros
            textMontoFinal.Text = Convert.ToString(monto);
            textTotalInteres.Text = Convert.ToString(total);
            
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textTotalInteres.Clear();
            textMontoFinal.Clear();
            textTiempo.Clear();
            textCapital.Clear();
            textRazon.Clear();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("monto", monto.ToString());
            Telegram.bot.Automatic_answer.textMessage("total", total.ToString());
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
