using CustomerManagement.Model;
using CustomerManagement.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Common
{
    public static class ApplicationSettings
    {
        public static string Culture
        {
            get { return Settings.Default.Culture; }
        }

        public static string CurrentUserLogin = Environment.UserName;
        
        
        private static User _currentUser;
        public static User CurrentUser
        {
            get
            {
                if (_currentUser == null)
                {
                    _currentUser = DataAccess.GetCurrentUser();
                }
                return _currentUser;
            }
        }

    }
}
