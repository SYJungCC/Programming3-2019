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

namespace Data_Entry_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cBox.Items.Add("1");
            cBox.Items.Add("2");
            cBox.Items.Add("3");
            cBox.Items.Add("4");
            cBox.Items.Add("5");

            listBox.Items.Add("COMP100");
            listBox.Items.Add("COMP213");
            listBox.Items.Add("COMP120");
            listBox.Items.Add("COMP125");

        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click Clear",  "CLEAR");
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click OK btn", "OK");
        }

    }
}
