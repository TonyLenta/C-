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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            ///c prbar---timer
            if (this.progressBar2.Value == 200)
            {
                this.timerTiempo.Enabled = false;
                this.Visible = false; ;
                Form2 frmMenu = new Form2();
                frmMenu.Show();
                //teclado_virtual.formularios.Teclado.frmTeclado frmteclado = new teclado_virtual.formularios.Teclado.frmTeclado();
                //frmteclado.Show();
            }
            else
            {
                this.progressBar2.Value += 10;
            }

        }
    }
}
