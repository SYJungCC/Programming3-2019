using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace OnlineShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Item
        {
            string name;
            double price;

            public Item(string name, double price)
            {
                this.name = name;
                this.price = price;
            }

            public string GetName()
            {
                return name; 
            }
            public double GetPrice()
            {
                return price;
            }
        }

        Item[] Electronics = new Item[]{
                                   new Item ("Phone" , 1000.0),
                                   new Item ("Mouse" , 400.0) ,
                                   new Item ("Moniter" , 300.0),
                                   new Item ("Computer"  ,500.0) };
        Item[] Books = new Item[]{
                                   new Item ( "Atomic Habits" , 1000.0),
                                   new Item ( "The blood Torch" , 400.0) ,
                                   new Item ( "Game of Throne" , 300.0),
                                   new Item ( "love yourself"  ,500.0) };

        Item[] Toys = new Item[]{
                                   new Item ("Toy1" , 1000.0),
                                   new Item ("ForKidToy" , 400.0) ,
                                   new Item ("Loving it" , 300.0),
                                   new Item ("Toy3333"  ,500.0) };

        Item[] Jewelry = new Item[]{
                                   new Item ("expensive" , 1000.0),
                                   new Item ("Gold" , 400.0) ,
                                   new Item ("Diamond" , 300.0),
                                   new Item ("ring"  ,500.0) };


        private double taxPrice = 0; 
        private double totalPrice = 0;
        private double subTotalPrice = 0;
        public MainWindow()
        {
            InitializeComponent();

      
            for (int i = 0; i < Electronics.Length; ++i)
                ElectronicsBox.Items.Add(Electronics[i].GetName() + "- $" + Electronics[i].GetPrice() );
            for (int i = 0; i < Books.Length; ++i)
                BooksBox.Items.Add(Books[i].GetName() + "- $" + Books[i].GetPrice());
            for(int i = 0; i < Toys.Length; ++i)
                ToysBox.Items.Add(Toys[i].GetName() + "- $" + Toys[i].GetPrice());
            for(int i = 0; i < Jewelry.Length; ++i)
                JewelryBox.Items.Add(Jewelry[i].GetName() + "- $" + Jewelry[i].GetPrice());


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            totalPrice = 0;
            taxPrice = 0;
            subTotalPrice = 0;
            SubTotalLabel.Content = "SubTotal : " + subTotalPrice;
            TaxLabel.Content = "Tax(13%) : " + taxPrice;
            TotalLabel.Content = "Total : " + totalPrice;
            LBox.Items.Clear();
        }

        void calcTotalandSubTotal(Item[] selectedItems, int index, string itemName)
        {
            LBox.Items.Add(itemName);
            subTotalPrice += selectedItems[index].GetPrice();
            taxPrice = subTotalPrice * 0.13;
            totalPrice = subTotalPrice + taxPrice;
            SubTotalLabel.Content = "SubTotal : $" + subTotalPrice;
            TaxLabel.Content = "Tax(13%) : $" + taxPrice; 
            TotalLabel.Content = "Total : $" + totalPrice;
        }
 
        private void ElectronicsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            calcTotalandSubTotal(Electronics, ElectronicsBox.SelectedIndex, ElectronicsBox.SelectedItem.ToString());
        }

        private void BooksBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            calcTotalandSubTotal(Electronics, BooksBox.SelectedIndex, BooksBox.SelectedItem.ToString());
        }

        private void ToysBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            calcTotalandSubTotal(Electronics, ToysBox.SelectedIndex, ToysBox.SelectedItem.ToString());
        }

        private void JewelryBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            calcTotalandSubTotal(Electronics, JewelryBox.SelectedIndex, JewelryBox.SelectedItem.ToString());
        }

        

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
