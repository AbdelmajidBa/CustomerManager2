﻿using CustomerManagement.ViewModel;
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
    /// Interaction logic for TopMenuControl.xaml
    /// </summary>
    public partial class TopMenuControl : UserControl
    {
        public TopMenuControl()
        {
            InitializeComponent();
        }


        #region Properties

        public TopMenuViewModel TopMenuViewModel
        {
            get { return DataContext as TopMenuViewModel; }
        }

        #endregion Properties
    }
}
