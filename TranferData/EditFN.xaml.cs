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
    public partial class EditFN : PhoneApplicationPage
    {
        public EditFN()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            tbxFN.Text = Global.FirstName;
            
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);


        }

        private void btnFNOk_Click(object sender, RoutedEventArgs e)
        {
            
            Global.Id = 0;
            Global.FirstName = tbxFN.Text;
            Uri newPage = new Uri("/MainPage.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }

        private void btnFNCancle_Click(object sender, RoutedEventArgs e)
        {
           
            Uri newPage = new Uri("/MainPage.xaml", UriKind.Relative);
            NavigationService.Navigate(newPage);
        }
    }
}