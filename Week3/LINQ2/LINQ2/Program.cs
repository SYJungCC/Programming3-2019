using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{

    public class ClientInfo
    {
        public int id;
        public string name;
        public string services;
        public string city;
        public double revenue;
        public bool type;

        public ClientInfo(int id, string name, string services, string city, double revenue, bool type)
        {
            this.id = id;
            this.name = name;
            this.services = services;
            this.city = city;
            this.revenue = revenue;
            this.type = type;
        }
    }

    class Program
    {
        public static IList<ClientInfo> clientList = new List<ClientInfo>()
            {
                new ClientInfo( 1 ,"BK Associates","Commercial", "Toronto" , 230000 , true ),
                new ClientInfo( 6 ,"Bick","Industrial", "Dallas" , 679000 , false ),
                new ClientInfo( 19,"THP","Government", "Atlanta" , 986000 , true ),
                new ClientInfo( 12,"Crow","Industrial", "Phoenix" , 126000 , false ),
                new ClientInfo( 56,"TX Electric","Industrial", "Portland" , 564000 , true ),
                new ClientInfo( 42,"GRB","Government", "Omaha" , 437000 , false ),
                new ClientInfo( 98,"LB&B","Commercial", "Toronto" , 990000 , true ),
                new ClientInfo( 44,"H&P","Commercial", "Denver" , 122000 , true ),
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
            TitleWriteLine("Q2-1");

            var idSorted = from cl in clientList
                           orderby cl.id
                           select cl;

            MakeClientTable(idSorted);
        }
        static void Question2()
        {
            TitleWriteLine("Q2-2");

            var nameAndCitySorted = from cl in clientList
                                    orderby cl.name, cl.city
                                    select cl;

            MakeClientTable(nameAndCitySorted);
        }
        static void Question3()
        {
            TitleWriteLine("Q2-3");

            var num3 = from cl in clientList
                       where cl.services == "Government"
                       orderby cl.revenue
                       select cl;

            MakeClientTable(num3);
        }
        static void Question4()
        {

            TitleWriteLine("Q2-4");

            var num4 = from cl in clientList
                       where cl.type == true
                       select cl;

            var totalNum = (from cl in clientList
                            where cl.type == true
                            select cl.revenue).Sum();

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Total Revenue: " + totalNum);
            Console.BackgroundColor = ConsoleColor.Black;

            MakeClientTable(num4);
        }
        static void Question5()
        {

            TitleWriteLine("Q2-5");

            var mostImportant = (from cl in clientList
                                 where cl.type = true
                                 orderby cl.revenue descending
                                 select cl).First();
            MakeClientTable(mostImportant);
        }
        public static void MakeClientTable(IEnumerable<ClientInfo> dataList)
        {
            Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|{4,18}|{5,18}|", "Client ID", "Client Name", "Client Services", "Client City", "Client Revenue", "Client type");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            foreach (var data in dataList)
            {
                Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|{4,18}|{5,18}|", data.id, data.name, data.services, data.city, data.revenue, (data.type == true ? "active" : "inactive"));
            }
        }
        public static void MakeClientTable(ClientInfo data)
        {
            Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|{4,18}|{5,18}|", "Client ID", "Client Name", "Client Services", "Client City", "Client Revenue", "Client type");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,18}|{1,18}|{2,18}|{3,18}|{4,18}|{5,18}|", data.id, data.name, data.services, data.city, data.revenue, (data.type == true ? "active" : "inactive"));
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
