using StudentsVer2._0.AppData;
using StudentsVer2._0.Model;
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

namespace StudentsVer2._0.View.Windows.Menu
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
            if (AuthorizationHelper.currentUser.RoleID == 1)
            {
                RoleNameTbl.Text = AuthorizationHelper.currentUser.Surname.ToString() +" "+ AuthorizationHelper.currentUser.Name.ToString();
            }
        }
    }
}
