using MyBookStore.BAL;
using MyBookStore.DAL;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for ProductDetails.xaml
    /// </summary>
    public partial class ProductDetails : Page
    {
        MainWindow mw = new MainWindow();
        Methods mt = new Methods();
        public static string book = "";

        public ProductDetails()
        {
            InitializeComponent();
            BookDetails();
        }


        private void BtnAddToCart_OnClick(object sender, RoutedEventArgs e)
        {
            //
        }

        public static void ViewBook(string str)
        {
            book = str;
        }

        private void BookDetails()
        {
            var list = mt.SearchBookName(book);

            foreach (BookTable bk in list)
            {
                ProductNameBlock.Text = bk.b_nm;
                ProductAuthorBlock.Text = bk.b_author;
                ProductIsbnBlock.Text = bk.b_isbn;
                ProductPublisherBlock.Text = bk.b_publisher;
                ProductEditionBlock.Text = bk.b_edition;
                ProductPageBlock.Text = bk.b_page.ToString();
                ProductPriceBlock.Text = bk.b_price.ToString();
                ProductImage.Source = new BitmapImage(new Uri(@"C:\\Users\\Amankeldi Kairbay\\source\\repos\\MyBookStore\\MyBookStore\\BooksImage\\" + bk.b_img, UriKind.Absolute));

            }
        }


    }
}
