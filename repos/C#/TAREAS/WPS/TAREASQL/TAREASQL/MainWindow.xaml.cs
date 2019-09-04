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

using System.Data.SqlClient;
using System.Data.SQLite;

namespace TAREASQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            SQLiteConnection sqIiteCon = new SQLiteConnection(dbConnectionString);

            // Open connection to database 

            try
            {
                sqliteCon.Open();
                string Query ="select fron employeeinfo ";
                SQLiteComnand createCommand = new SQLiteCommand(Query, sq1iteCon);

                createComand.ExecuteNonQuery();
                sq1iteCon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
        }
}
