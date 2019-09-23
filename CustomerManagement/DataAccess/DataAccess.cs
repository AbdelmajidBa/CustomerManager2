using CustomerManagement.Common;
using CustomerManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class DataAccess
    {
        public static User GetCurrentUser()
        {

            var users = new List<User>
            {
                new User(){ EmailAddress="user1@mail.com", FirstName="FirstName1", LastName="LastName1", Login="user1"},
                new User(){ EmailAddress="user2@mail.com", FirstName="FirstName2", LastName="LastName2", Login="user2"},
                new User(){ EmailAddress="user3@mail.com", FirstName="FirstName3", LastName="LastName3", Login="user3"},
                new User(){ EmailAddress="user4@mail.com", FirstName="FirstName4", LastName="LastName4", Login="abaco"},
                new User(){ EmailAddress="user5@mail.com", FirstName="FirstName5", LastName="LastName5", Login="user5"},
            };



            return users.SingleOrDefault(u => u.Login.ToUpper() == ApplicationSettings.CurrentUserLogin.ToUpper());
        }
    }
}
