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

namespace Temperature_conversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double celsius = 0;
                double fahrenheit = 0;
                Double.TryParse(TempTB.Text, out fahrenheit);
                celsius = (5.0 / 9.0) * (fahrenheit - 32.0f);
                Temp2TB.Text = celsius.ToString();
            }
            catch (FormatException)
            {
            };
         
        }
    }
}
