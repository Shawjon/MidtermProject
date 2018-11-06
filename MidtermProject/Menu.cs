using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Menu
    {
        public Menu()
        {
        }
        public static void getMainMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------------------------------\n" +
                              "|   Welcome to Roaming Ramen, a noodle shop ToGo          |\n" +
                              "|            What would you like to do?                   |\n" +
                              "-----------------------------------------------------------");
            Console.WriteLine("1. Look at the menu");
            Console.WriteLine("2. Start an order ");
            Console.ResetColor();
        }
        public static void PrintList(List<Product> productList)

        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------------------------------\n" +
                              "|     Author               Title              Checked out?|\n" +
                              "|     Name  (First,Last)                            (Y/N) |\n" +
                              "-----------------------------------------------------------");
            ///Console.ResetColor();
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"#{(i + 1)}{"|"}  {productList[i].name}, A {productList[i].category} that costs ${productList[i].price}.\n  |  {productList[i].description}. We have {productList[i].quanity} ");
            }

        }
    }
}
