using StudentsVer2._0.AppData;
using StudentsVer2._0.Model;
using StudentsVer2._0.View.Windows.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace StudentsVer2._0.View.Windows.Login
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorizationHelper.CheckData(LoginTb.Text, PasswordTb.Text) == true)
            {
                MessageBox.Show("Успешный вход в систему");
                MainMenuWindow mainMenuWindow = new MainMenuWindow();
                mainMenuWindow.Show();
            }
            else 
            {
                MessageBox.Show("Данные неверны");
            }
        }

    }
}
