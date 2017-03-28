using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDT_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu firstPage = new mainMenu();
            firstPage.mainPage();
        }
    }

    class mainMenu
    {
        public void mainPage()
        {
            Console.WriteLine("Welcome to Marvellous Magic");
            Console.WriteLine("===============================");
            Console.WriteLine("1. Owner\n");
            Console.WriteLine("2. Franchise Owner\n");
            Console.WriteLine("3. Customer\n");
            Console.WriteLine("4. Quite\n");
            Console.ReadKey();
        }

    }

}
