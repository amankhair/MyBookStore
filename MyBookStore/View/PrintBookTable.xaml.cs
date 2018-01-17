using MyBookStore.BAL;
using MyBookStore.DAL;
using System.Windows;
using System.Windows.Controls;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for PrintBookTable.xaml
    /// </summary>
    public partial class PrintBookTable : Page
    {
        Methods mt = new Methods();
        public PrintBookTable()
        {
            InitializeComponent();

            BookTableList.ItemsSource = mt.GetBookTable();
        }

        private void BtnAddBook_OnClick(object sender, RoutedEventArgs e)
        {
            BookTable bk = new BookTable();

            bk.b_author = BookAuthorBox.Text;
            bk.b_desc = BookDescriptionBox.Text;
            bk.b_edition = BookDescriptionBox.Text;
            bk.b_img = BookImageBox.Text;
            bk.b_isbn = BookIsbnBox.Text;
            bk.b_nm = BookNameBox.Text;
            bk.b_page = int.Parse(BookPageBox.Text);
            bk.b_pdf = BookPdfBox.Text;
            bk.b_price = int.Parse(BookPriceBox.Text);
            bk.b_publisher = BookPublisherBox.Text;
            bk.b_subcat = BookSubСatBox.Text;

            mt.AddNewBook(bk);
        }

        private void BtnDeleteBook_OnClick(object sender, RoutedEventArgs e)
        {
            BookTable bk = new BookTable();

            bk.b_author = BookAuthorBox.Text;
            bk.b_desc = BookDescriptionBox.Text;
            bk.b_edition = BookDescriptionBox.Text;
            bk.b_img = BookImageBox.Text;
            bk.b_isbn = BookIsbnBox.Text;
            bk.b_nm = BookNameBox.Text;
            bk.b_page = int.Parse(BookPageBox.Text);
            bk.b_pdf = BookPdfBox.Text;
            bk.b_price = int.Parse(BookPriceBox.Text);
            bk.b_publisher = BookPublisherBox.Text;
            bk.b_subcat = BookSubСatBox.Text;

            mt.DeleteBook(bk);
        }
    }
}
