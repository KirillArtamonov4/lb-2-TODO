using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox instance = (TextBox)sender;
            if (instance.Text == instance.Tag.ToString())
                instance.Text = "";
            instance.Opacity = 1;
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox instance = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(instance.Text))
                instance.Text = instance.Tag.ToString();
            instance.Opacity = 0.4;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = emailTB.Text;
            string password = passwordTB.Text;
            string name = nameTB.Text;

            if (!name.ValidateName())
            {
                MessageBox.Show("Имя должно содержать 3 или более символов");
                return;
            }

            if (!email.ValidateEmail())
            {
                // error
                MessageBox.Show("Некорректная почта");
                return;
            }

            if (!password.ValidatePassword())
            {
                MessageBox.Show("Пароль должен содержать 6 символов или более");
                return;
            }
            if (passwordTB.Text != againpasswordTB.Text)
            {
                MessageBox.Show("Пароли должны совпадать");
                return;
            }

            if (email.ValidateEmail() && password.ValidatePassword() && name.ValidateName())
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }


            if (email.ValidateEmail() && password.ValidatePassword() && name.ValidateName())
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Hide();
        }
    }
}
