using StudentsVer2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsVer2._0.AppData
{
    internal class AuthorizationHelper
    {
        public static string login;
        public static string password;
        public static User currentUser = App.context.User.FirstOrDefault(u => u.Login == login && u.Password == password);
    }
}
