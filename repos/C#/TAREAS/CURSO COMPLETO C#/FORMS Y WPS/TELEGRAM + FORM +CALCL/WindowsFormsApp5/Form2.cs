using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        double suma;
        public Form2()
        {
            //declaromos libreria que destacargamos para telegram
            Telegram.bot bot = new Telegram.bot();
            Telegram.bot.token = "593386107:AAHcv6vdtMNlp0JRV9WC0sCoTG1JjXZOzr4";
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //entrada
            //declaracion de variable
            double num1, num2;
            
            //asignacion
            num1 = Convert.ToDouble(textNumero1.Text);
            num2 = Convert.ToDouble(textNumero2.Text);


            //proceso
            suma = num1 + num2;

            //salida 
            labelResultado1.Text = Convert.ToString(suma);








        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textNumero1.Clear();
            textNumero2.Clear();
            labelResultado1.Text = "";

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("Suman", suma.ToString());

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
