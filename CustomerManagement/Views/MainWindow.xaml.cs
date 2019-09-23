using CustomerManagement.Common;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomerManagement.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var topMenuViewModel = TopMenuControl.TopMenuViewModel;

            topMenuViewModel.ListCustomersTriggered += OnListCustomersTriggered;
            topMenuViewModel.NewCustomerTriggered += OnNewCustomerTriggered;
            topMenuViewModel.FindCustomerTriggered += OnFindCustomerTriggered;
        }

        #region Methods

        private bool TabExists(string tabName)
        {
            var item = TabControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabName)).SingleOrDefault();
            if (item != null)
            {
                TabControl.SelectedIndex = TabControl.Items.IndexOf(item);
                return true;
            }
            return false;
        }


        private void OnListCustomersTriggered(object sender, EventArgs e)
        {

            if (!TabExists("ListCustomers"))
            {
                TabItem tab = new TabItem();
                tab.Header = ApplicationResourceManager.GetRessourcesValue("List_Customer");
                tab.Name = "ListCustomers";
                tab.HeaderTemplate = TabControl.FindResource("TabHeader") as DataTemplate;
                tab.Content = new ListCustomersView();
                TabControl.Items.Insert(0, tab);
                TabControl.SelectedIndex = 0;
            }
            
        }

        private void OnNewCustomerTriggered(object sender, EventArgs e)
        {
            if (!TabExists("NewCustomer"))
            {
                TabItem tab = new TabItem();
                tab.Header = ApplicationResourceManager.GetRessourcesValue("New_Customer");
                tab.Name = "NewCustomer";
                tab.HeaderTemplate = TabControl.FindResource("TabHeader") as DataTemplate;
                tab.Content = new NewCustomerView();
                TabControl.Items.Insert(0, tab);
                TabControl.SelectedIndex = 0;
            }
        }

        private void OnFindCustomerTriggered(object sender, EventArgs e)
        {
            if (!TabExists("FindCustomer"))
            {
                TabItem tab = new TabItem();
                tab.Header = ApplicationResourceManager.GetRessourcesValue("Find_Customer");
                tab.Name = "FindCustomer";
                tab.HeaderTemplate = TabControl.FindResource("TabHeader") as DataTemplate;
                tab.Content = new FindCustomerView();
                TabControl.Items.Insert(0, tab);
                TabControl.SelectedIndex = 0;
            }
        }
        #endregion Methods

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string tabName = (sender as Button).CommandParameter.ToString();
            var item = TabControl.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabName)).SingleOrDefault();
            TabControl.Items.Remove(item);
    
        }
    }
}
