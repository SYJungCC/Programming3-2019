using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{

    public class ItemInfo
    {
        public string group;
        public string description;
        public int quantity;
        public double price;

        public ItemInfo(string group, string description, int quantity, double price)
        {
            this.group = group;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
        }
    }

    class Program
    {
        public static IList<ItemInfo> ItemList = new List<ItemInfo>()
            {
                new ItemInfo( "Electric", "Eectric sander" , 7 , 59.98 ),
                new ItemInfo( "Electric", "Power saw" , 18 , 99.99 ),
                new ItemInfo( "Pneumatic", "Nail Gun" , 11 , 121.55 ),
                new ItemInfo( "Manual", "Hammer" , 76 , 11.99 ),
                new ItemInfo( "Electric", "Lawn mower" , 3 , 79.95 ),
                new ItemInfo( "Manual", "Screwdriver" , 106 , 7.99 ),
                new ItemInfo( "Electric", "Jig Saw" , 21 , 11.95 ),
                new ItemInfo( "Manual", "Wrench" , 34 , 7.95 ),
                new ItemInfo( "Pneumatic", "Air brush" , 55 , 44.50 ),
            };

        static void Main(string[] args)
        {

            Question1();
            Question2();
            Question3();
            Question4();
            Question5();
        }

        static void Question1()
        {
            var nameSorted = from it in ItemList
                             orderby it.description
                             select it;

            TitleWriteLine("Q1-1");

            Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|", "Item Group", "Item description", "Quantity", "Unit Price");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (var data in nameSorted)
            {
                Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|", data.group, data.description, data.quantity, data.price);
            }

        }

        static void Question2()
        {
            TitleWriteLine("Q1-2");

            var selDesNquan = from it in ItemList
                              orderby it.quantity
                              select new { description = it.description, quantity = it.quantity };

            Console.WriteLine("{0,18}|{1,18}|", "Description", "Quantity");
            Console.WriteLine("---------------------------------------");
            foreach (var data in selDesNquan)
            {
                Console.WriteLine("{0,18}|{1,18}|", data.description, data.quantity);
            }
        }

        static void Question3()
        {
            TitleWriteLine("Q1-3");

            var selDesNtotal = from it in ItemList
                               group it by new { description = it.description, total = it.price * it.quantity } into itemGroup
                               orderby itemGroup.Key.total
                               select itemGroup.Key;

            Console.WriteLine("{0,18}|{1,18}|", "Description", "Total");
            Console.WriteLine("---------------------------------------");
            foreach (var data in selDesNtotal)
            {
                Console.WriteLine("{0,18}|{1,18}|", data.description, data.total);
            }
        }

        static void Question4()
        {
            TitleWriteLine("Q1-4");

            //Same  with var mostExpensive = ItemList.OrderByDescending(x => x.price).First();
            var mostExpensive = (from it in ItemList
                                 orderby it.price descending
                                 select it).First();

            MakeItemTable(mostExpensive);

        }

        static void Question5()
        {
            TitleWriteLine("Q1-5");

            var reduce10 = from it in ItemList
                           select new
                           {
                               description = it.description,
                               @group = it.@group,
                               price = it.price - (it.price * 0.1),
                               quantity = it.quantity
                           };

            Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|", "Item Group", "Item description", "Quantity", "Unit Price");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (var ns in reduce10)
            {
                Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|", ns.group, ns.description, ns.quantity, ns.price);
            }
        }
   
        public static void MakeItemTable(ItemInfo data)
        {
            Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|", "Item Group", "Item description", "Quantity", "Unit Price");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|", data.group, data.description, data.quantity, data.price);
        }
        public static void TitleWriteLine(string questionInfo)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("★    " + questionInfo + "    ★");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
