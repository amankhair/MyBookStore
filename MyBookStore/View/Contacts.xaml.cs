using System.Windows.Controls;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        public Contacts()
        {
            InitializeComponent();
            ShopName.Content = "\"Книжная полка\".";
        }
    }
}
