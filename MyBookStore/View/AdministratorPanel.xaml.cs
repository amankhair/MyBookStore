using System;
using System.Windows;
using System.Windows.Controls;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for AdministratorPanel.xaml
    /// </summary>
    public partial class AdministratorPanel : Page
    {
        public AdministratorPanel()
        {
            InitializeComponent();
        }
        private void PrintBookTable_OnClick(object sender, RoutedEventArgs e)
        {
            TableFrame.Source = new Uri("PrintBookTable.xaml", UriKind.RelativeOrAbsolute);

        }

        private void PrintCategoryTable_OnClick(object sender, RoutedEventArgs e)
        {
            TableFrame.Source = new Uri("PrintCategoryTable.xaml", UriKind.RelativeOrAbsolute);
        }

        private void PrintContactTable_OnClick(object sender, RoutedEventArgs e)
        {
            TableFrame.Source = new Uri("PrintContactTable.xaml", UriKind.RelativeOrAbsolute);
        }

        private void PrintSubcatTable_OnClick(object sender, RoutedEventArgs e)
        {
            TableFrame.Source = new Uri("PrintSubcatTable.xaml", UriKind.RelativeOrAbsolute);
        }

        private void PrintUserTable_OnClick(object sender, RoutedEventArgs e)
        {
            TableFrame.Source = new Uri("PrintUserTable.xaml", UriKind.RelativeOrAbsolute);
        }

        private void AddNewBook_OnClick(object sender, RoutedEventArgs e)
        {
            //TableFrame.Source = new Uri("AddNewBook.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
