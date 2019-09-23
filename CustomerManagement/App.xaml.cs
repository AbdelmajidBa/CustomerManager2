using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Globalization;
using CustomerManagement.Common;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using CustomerManagement.Properties;

namespace CustomerManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        protected override void OnStartup(StartupEventArgs e)
        {
            //Occurs when an exception is thrown by an application but not handled.
            Current.DispatcherUnhandledException += OnDispatcherUnhandledException;

            var processesCount = Process.GetProcessesByName("CustomerManagement").Length;
            if (processesCount <= 1)
            {
                //Localization (en, fr-FR, ar-MA)
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ApplicationSettings.Culture);

                var hasAccess = false;
                try
                {
                    //Manage user Acces here
                    hasAccess = ApplicationSettings.CurrentUser!=null;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
                finally
                {
                    if (!hasAccess)
                    {
                        MessageBox.Show("You don't have permission to access this application");
                    }
                    else
                    {
                        base.OnStartup(e);
                    }
                }
                
            }
            else Environment.Exit(0);
        }


        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }
    }
}
