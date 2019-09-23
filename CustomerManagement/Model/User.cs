using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Model
{
    public class User
    {

        #region Properties

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                //OnPropertyChanged();
            }
        }

        public string FullName
        {
            get { return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) ? string.Format("{0} {1}", LastName.ToUpper(), FirstName) : string.Empty; }
        }

        public bool IsAdmin { get; set; }

        public bool IsReader { get; set; }

        public bool IsWriter { get; set; }

        public  bool IsValid
        {
            get { return true; }
        }

        

        #endregion Properties


    }
}
