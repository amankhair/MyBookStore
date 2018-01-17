using MyBookStore.BAL;
using MyBookStore.View;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MyBookStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Methods mt = new Methods();


        public MainWindow()
        {
            InitializeComponent();
            CategoryName();
        }


        private void BtnRegister_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("Registration and login/Registration.xaml", UriKind.RelativeOrAbsolute);
        }

        private void BtnLogin_OnClick(object sender, RoutedEventArgs e)
        {
            // RegFrame.Source = new Uri("View/LoginForm.xaml", UriKind.RelativeOrAbsolute);
        }

        private void BtnBasket_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void BtnHome_OnClick(object sender, RoutedEventArgs e)
        {

            MainFrame.Source = new Uri("View/AdministratorPanel.xaml", UriKind.RelativeOrAbsolute);
        }

        private void BtnAboutUs_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/AboutUs.xaml", UriKind.RelativeOrAbsolute);
        }

        private void BtnContacts_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/Contacts.xaml", UriKind.RelativeOrAbsolute);
        }


        private void CategoryBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CategoryName()
        {
            CategoryBox.DataContext = mt.GetCategoryName();
        }

        private void BtnSearch_OnClick(object sender, RoutedEventArgs e)
        {
            ProductDetails.ViewBook(SearchBox.Text);
            MainFrame.Source = new Uri("View/ProductDetails.xaml", UriKind.RelativeOrAbsolute);

        }

        public string SearchBook()
        {
            string str = SearchBox.Text;
            return str;
        }


    }
}
