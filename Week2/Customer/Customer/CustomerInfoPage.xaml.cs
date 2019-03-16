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
    /// <summary>
    /// Interaction logic for CustomerInfoPage.xaml
    /// </summary>
    public partial class CustomerInfoPage : Page
    {
        public CustomerInfoPage()
        {
            InitializeComponent();
        }

        public CustomerInfoPage(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }

        public void CanModifyData()
        {
            NameHead.Visibility = Visibility.Hidden;
            LabelName.Visibility = Visibility.Visible;
            LabelID.IsEnabled = true;
            LabelAddress.IsEnabled = true;
            LabelCity.IsEnabled = true;
            LabelCompanyName.IsEnabled = true;
            LabelContactName.IsEnabled = true;
            LabelContactTitle.IsEnabled = true;
            LabelCountry.IsEnabled = true;
        }

        public void DeleteData()
        {

        }

        public void AddData()
        {

        }
    }
}
