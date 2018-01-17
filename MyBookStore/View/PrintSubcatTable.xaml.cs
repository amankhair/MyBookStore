using MyBookStore.BAL;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for PrintSubcat.xaml
    /// </summary>
    public partial class PrintSubcat : Page
    {
        Methods mt = new Methods();

        public PrintSubcat()
        {
            InitializeComponent();

            SubcatTableList.ItemsSource = mt.GetSubcatTable();
        }

        private void BtnAddSubcat_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDeleteSubcat_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
