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

namespace Drawing_Panel
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

        private void inkCanvas1_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
            
        }

        //Color 
        private void RedBtn_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Color.FromRgb(255, 0, 0);
        }
        private void BlueBtn_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 255);
        }
        private void BlackBtn_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0,0);
        }

        private void GreenBtn_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = Color.FromRgb(0, 255, 0);
        }


        //Size
        private void MediumBtn_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Height = 6;
            inkCanvas1.DefaultDrawingAttributes.Width = 6;
        }
        private void SmallBtn_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Height = 2;
            inkCanvas1.DefaultDrawingAttributes.Width = 2;

        }
        private void LargeBtn_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Height = 10;
            inkCanvas1.DefaultDrawingAttributes.Width = 10;
        }
    }
}
