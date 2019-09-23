using CustomerManagement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.ViewModel
{
    public class TopMenuViewModel
    {

        private void Exit()
        {
            App.Current.Shutdown();
        }

        private void ListCustomers()
        {
            ListCustomersTriggered(null, null);
        }
        private void NewCustomer()
        {
            NewCustomerTriggered(null, null);
        }
        private void FindCustomer()
        {
            FindCustomerTriggered(null, null);
        }
        #region Events
        public event EventHandler ListCustomersTriggered;
        public event EventHandler NewCustomerTriggered;
        public event EventHandler FindCustomerTriggered;


        #endregion Events


        #region Commands

        private RelayCommand _exitCommand;
        public RelayCommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                {
                    _exitCommand = new RelayCommand(o => Exit(), (o) => { return true; });
                }
                return _exitCommand;
            }
        }

        private RelayCommand _listCustomersCommand;
        public RelayCommand ListCustomersCommand
        {
            get
            {
                if (_listCustomersCommand == null)
                {
                    _listCustomersCommand = new RelayCommand(o => ListCustomers(), (o) => { return true; });
                }
                return _listCustomersCommand;
            }
        }

        private RelayCommand _findCustomerCommand;
        public RelayCommand FindCustomerCommand
        {
            get
            {
                if (_findCustomerCommand == null)
                {
                    _findCustomerCommand = new RelayCommand(o => FindCustomer(), (o) => { return true; });
                }
                return _findCustomerCommand;
            }
        }

        private RelayCommand _newCustomerCommand;
        public RelayCommand NewCustomerCommand
        {
            get
            {
                if (_newCustomerCommand == null)
                {
                    _newCustomerCommand = new RelayCommand(o => NewCustomer(), (o) => { return true; });
                }
                return _newCustomerCommand;
            }
        }

        #endregion Commands
    }
}
