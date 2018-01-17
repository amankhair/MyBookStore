using MyBookStore.BAL;
using System;
using System.Windows;
using System.Windows.Controls;
using UserClassLibrary;

namespace MyBookStore.Registration_and_login
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        Methods mt = new Methods();


        public Registration()
        {
            InitializeComponent();
        }

        private void BtnConfirm_OnClick(object sender, RoutedEventArgs e)
        {
            string gender = "";

            if (RadioButtonMale.IsChecked == false && RadioButtonFemale.IsChecked == false)
            {
                MessageBox.Show("Выберите пол");

                RegFrame.Source = new Uri("Registration.xaml", UriKind.RelativeOrAbsolute);
            }
            else if (RadioButtonMale.IsChecked == true)
            {
                gender = "Муж";
            }
            else if (RadioButtonFemale.IsChecked == true)
            {
                gender = "Жен";
            }
            //else if (!(EmailBox.Text.Contains("@")))
            //{
            //    throw new Exception("Пароли не совпадают!!!");
            //    //MessageBox.Show("Неверный формат email");
            //}
            //else if (!(PasswordBox1.Text == PasswordBox2.Text))
            //{
            //    MessageBox.Show("Пароли не совпадают");

            //    RegFrame.Source = new Uri("Registration.xaml", UriKind.RelativeOrAbsolute);
            //}
            try
            {
                User.Registration(gender, NameBox.Text, LastNameBox.Text, EmailBox.Text, PhoneBox.Text, LoginBox.Text, PasswordBox1.Text, CityBox.Text);
                MessageBox.Show("Nice!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
