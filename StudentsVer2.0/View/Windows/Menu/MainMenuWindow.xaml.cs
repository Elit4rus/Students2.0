using StudentsVer2._0.AppData;
using StudentsVer2._0.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace StudentsVer2._0.View.Windows.Menu
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        // Создаем список пользователей
        List<Student> students = App.context.Student.ToList();
        public MainMenuWindow()
        {
            InitializeComponent();
            // Загружаем список пользователей
            StudentsLv.ItemsSource = students;

            // Авторизация пользователя
            RoleNameTbl.Text = AuthorizationHelper.currentUser.Role.Title;
            AccountNameTbl.Text = AuthorizationHelper.currentUser.Surname + " " + AuthorizationHelper.currentUser.Name;

            // Передаем данные в ComboBox
            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Title";

            GroupCmb.ItemsSource = App.context.Group.Where(g => g.).ToList();
        }

        private void StudentsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
