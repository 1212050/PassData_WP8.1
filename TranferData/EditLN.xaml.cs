using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TranferData
{
    public partial class EditLN : PhoneApplicationPage
    {
        public EditLN()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            tbxLN.Text = Global.LastName;
        }

        private void btnLNOk_Click(object sender, RoutedEventArgs e)
        {
         
            Global.LastName = tbxLN.Text;
            Global.Id = 1;
            Uri newPage = new Uri("/MainPage.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        private void btnLNCancel_Click(object sender, RoutedEventArgs e)
        {
          
            Uri newPage = new Uri("/MainPage.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        
    }
}