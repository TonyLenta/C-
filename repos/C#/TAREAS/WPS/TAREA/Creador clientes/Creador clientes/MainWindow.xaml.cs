using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
using System.Data.OleDb;//agrega base de dato
using System.IO;
using System.Windows.Shapes;
using System.Data;

namespace Creador_clientes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\L-BOSS-W-001\\Documents\\BASE DATOS\\Clientes.accdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter(@"Cliente * from Nombre", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\L-BOSS-W-001\\Documents\\BASE DATOS\\Clientes.accdb");

        public MainWindow()
        {
            
            InitializeComponent();
            Conexion.Open();
           

        }

      
        

        private void btnAgre_Click(object sender, RoutedEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            DataSet memorytable = new DataSet();



            int i = 0;
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Debe completar la informacion");
            }
            else
            {
                cmd.Connection = Conexion;
                cmd.CommandText = "INSERT INTO Cliente(Nombre, Apellido, Cell) Values('" + txtNom.Text + "','" + txtApell.Text + "', '" + txtCell.Text + "')";
                i = cmd.ExecuteNonQuery();

                {

                    cmd.Parameters.AddWithValue("@Nombre", txtNom);
                    cmd.Parameters.AddWithValue("@Apellido", txtApell);
                    cmd.Parameters.AddWithValue("@Curso", txtCell);
                    MessageBox.Show("Guardado");
                    txtNom.Clear();
                    txtApell.Clear();
                    txtCell.Clear();
                }
               // adapter.Fill(memorytable);
               // data.DataContext = memorytable;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
}
