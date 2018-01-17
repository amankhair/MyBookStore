using MyBookStore.BAL;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for PrintContactTable.xaml
    /// </summary>
    public partial class PrintContactTable : Page
    {
        Methods mt = new Methods();

        public PrintContactTable()
        {
            InitializeComponent();

            ContactTableList.ItemsSource = mt.GetContactTable();
        }

        private void BtnAddContact_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDeleteBook_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
