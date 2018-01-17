using MyBookStore.BAL;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for PrintUserTable.xaml
    /// </summary>
    public partial class PrintUserTable : Page
    {
        Methods mt = new Methods();

        public PrintUserTable()
        {
            InitializeComponent();

            UserTableList.ItemsSource = mt.GetUserTable();
        }

        private void BtnAddUser_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDeleteUser_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
