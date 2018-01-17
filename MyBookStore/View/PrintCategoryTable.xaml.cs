using MyBookStore.BAL;
using MyBookStore.DAL;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for PrintCategoryTable.xaml
    /// </summary>
    public partial class PrintCategoryTable : Page
    {
        Methods mt = new Methods();

        public PrintCategoryTable()
        {
            InitializeComponent();

            CategoryTableList.ItemsSource = mt.GetCategoryTable();
        }


        private void BtnAddCategory_OnClick(object sender, RoutedEventArgs e)
        {
            CategoryTable ct = new CategoryTable();
            ct.cat_id = int.Parse(CategoryIdBox.Text);
            ct.cat_nm = CategoryNameBox.Text;

            mt.AddNewCategory(ct);

        }

        private void BtnDeleteCategory_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
