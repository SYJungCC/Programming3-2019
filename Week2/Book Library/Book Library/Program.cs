using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{
    delegate void MyDelegate(Dictionary<string, Book> books); 

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> bookLib = new Dictionary<string, Book>();
            MyDelegate mDel;

            Book b1 = new Book("Abook1","SY",23,eCoverType.softCover);
            bookLib.Add(b1.getTitle(), b1);

            Book b2 = new Book("book2","Filps",199,eCoverType.hardCover);
            bookLib.Add(b2.getTitle(), b2);

            Book b3 = new Book("Abook3","Lesile",555,eCoverType.softCover);
            bookLib.Add(b3.getTitle(), b3);

            Book b4 = new Book("book4","SY",333, eCoverType.softCover);
            bookLib.Add(b4.getTitle(), b4);

            mDel = new MyDelegate(CoverandAvgPrice);
            mDel(bookLib);
            mDel = new MyDelegate(mostExpensiveBook);
            mDel(bookLib);
            mDel = new MyDelegate(sortByTitle);
            mDel(bookLib);
        }


        public static void CoverandAvgPrice(Dictionary<string, Book> books)
        {
            Console.WriteLine("============================ CoverandAvgPrice");

            int bookNum = 0;
            int avgPrice = 0;
            int totalPrice = 0;
            foreach (KeyValuePair<string, Book> item in books)
            {
                if (item.Value.getCoverType() == eCoverType.softCover)
                {
                    bookNum++;
                    totalPrice = item.Value.getPrice();
                    Console.WriteLine("Title : {0}, Author : {1}, Price : {2}, CoverType : {3}", item.Value.getTitle(),
                                                           item.Value.getAuthor(),
                                                           item.Value.getPrice(),
                                                           item.Value.getCoverType() == eCoverType.softCover ? "SoftCover" : "HardCover");
                }
            }
            avgPrice = totalPrice / bookNum;
            Console.WriteLine("Average SoftCover Book's price is {0}", avgPrice);
        }

        public static void mostExpensiveBook(Dictionary<string, Book> books)
        {
            Console.WriteLine("============================  MostExpensiveBook");

            int mostExpensiveBook = 0;
            foreach (KeyValuePair<string, Book> item in books)
            {
                if (item.Value.getPrice() >= mostExpensiveBook)
                {
                    mostExpensiveBook = item.Value.getPrice();
                }
            }
            Console.WriteLine("MostExpensiveBook : {0}", mostExpensiveBook);
        }

        public static void sortByTitle(Dictionary<string, Book> books)
        {
            Console.WriteLine("============================ SortByTitle");

            var result= books.OrderBy(a => a.Key);

            foreach (KeyValuePair<string, Book> item in result)
            {
                Console.WriteLine("Title : {0}, Author : {1}, Price : {2}, CoverType : {3}", item.Value.getTitle(),
                                                                  item.Value.getAuthor(),
                                                                  item.Value.getPrice(),
                                                                  item.Value.getCoverType() == eCoverType.softCover ? "SoftCover" : "HardCover");
            }
        }
    }
}
