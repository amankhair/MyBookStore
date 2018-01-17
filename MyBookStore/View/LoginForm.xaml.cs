using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace MyBookStore.View
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Page
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void BtnLoginForm_OnClick(object sender, RoutedEventArgs e)
        {
            ShowBox.Height = 300;
            ShowBox.Width = 400;
            ShowLabel.FontSize = 25;
            ShowLabel.HorizontalAlignment = HorizontalAlignment.Center;
            ShowLabel.VerticalAlignment = VerticalAlignment.Center;
            ShowLabel.Foreground = new SolidColorBrush(Colors.Red);
            ShowBorder.Background = new SolidColorBrush(Colors.White);
            ShowLabel.Content = "Ошибка!!!";
            ShowBorder.BorderThickness = new Thickness(2, 2, 2, 2);
            ShowBorder.BorderBrush = new SolidColorBrush(Colors.Blue);
            ShowBorder.Effect = new DropShadowEffect();

        }
    }
}
