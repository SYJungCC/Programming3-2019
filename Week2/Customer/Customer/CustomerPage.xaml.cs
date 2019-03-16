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

namespace Customer
{
    public class CustomerInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Country { get; set; }
    }
    /// <summary>
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {

        public List<CustomerInfo> customerInfoList = new List<CustomerInfo>()
        {
            new CustomerInfo() { Id = "1984732",  Name= "SeoYoung", CompanyName = "SY Company", Address="Secret1", City = "Seoul", ContactName="Rudolph", ContactTitle ="Programmer", Country="South Korea"},
            new CustomerInfo() { Id = "355662",  Name= "Qristi", CompanyName = "Perrier", Address="Secret2", City = "otherplace", ContactName="dance", ContactTitle ="HR", Country="Mexico"},
            new CustomerInfo() { Id = "DX382345",  Name= "Deigo", CompanyName = "Perrier", Address="Secret3", City = "somewhere", ContactName="Rudolph", ContactTitle ="Business", Country="Mexico"},
            new CustomerInfo() { Id = "KK234232",  Name= "Eden", CompanyName = "Pamplemousse", Address="Secret4", City = "London", ContactName="invention", ContactTitle ="Chemistry", Country="England"},
            new CustomerInfo() { Id = "AA3423444",  Name= "Andress", CompanyName = "SY Company", Address="Secret5", City = "idk", ContactName="hiru", ContactTitle ="mechanic", Country="South Korea"},
        };

        CustomerInfoPage infoPage = null; 
        public CustomerPage()
        {
            InitializeComponent();
            peopleListView.ItemsSource = customerInfoList;
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            CustomerInfo cInfo = new CustomerInfo()
            {
                Id = " ",
                Name = "NoName",
                CompanyName = "NoName",
                Address = " ",
                City = " ",
                ContactName = " ",
                ContactTitle = " ",
                Country = " "
            };

            customerInfoList.Add(cInfo);
            peopleListView.ItemsSource = customerInfoList;
            peopleListView.Items.Refresh();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if(peopleListView.SelectedIndex != -1)
            {
                int index = peopleListView.SelectedIndex;
                customerInfoList.RemoveAt(index);
                peopleListView.ItemsSource = customerInfoList;
                peopleListView.Items.Refresh();
            }
        }


        private void BtnModify_Click(object sender, RoutedEventArgs e)
        {
            if(infoPage != null)
            {
                infoPage.CanModifyData();
            }
        }

        private void PeopleListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            infoPage = new CustomerInfoPage(peopleListView.SelectedItem);
            frameInfo.NavigationService.Navigate(infoPage);
        }
    }
}
