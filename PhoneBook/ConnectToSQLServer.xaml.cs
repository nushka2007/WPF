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
using System.Windows.Shapes;

using System.Data;
using System.Data.SqlClient;
using PhoneBook.Classes;
namespace PhoneBook
{
    /// <summary>
    /// Логика взаимодействия для ConnectToSQLServerWindow.xaml
    /// </summary>
    public partial class ConnectToSQLServerWindow : Window
    {
        public ConnectToSQLServerWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DBClass.openConnection();

            DBClass.sql = "SELECT [CustomerID], [FirstName], [LastName], [Age], [City], [PhoneNumber] FROM Customers;";
            DBClass.cmd.CommandType = CommandType.Text;
            DBClass.cmd.CommandText = DBClass.sql;

            DBClass.da = new SqlDataAdapter(DBClass.cmd);
            DBClass.dt = new DataTable();
            DBClass.da.Fill(DBClass.dt);

            myDataGrid.ItemsSource = DBClass.dt.DefaultView;

            DBClass.closeConnection();
        }
    }
}
