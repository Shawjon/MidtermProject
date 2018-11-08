using System;
using System.Collections.Generic;
using System.IO;
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
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------\n" +
                              "|   Welcome to Roaming Ramen, a ToGo noodle shop          |\n" +
                              "|            What would you like to do?                   |\n" +
                              "-----------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("1. Look at the menu ");
            Console.WriteLine("2. Start an order ");
            Console.WriteLine("3. Leave ");
        }
        public static void PrintList(List<Product> productList)

        {
           
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------------------------------\n" +
                              "|                          Menu                           |\n" +
                              "-----------------------------------------------------------");
            Console.ResetColor();
            for (int i = 0; i < productList.Count; i++)
            {
               Console.WriteLine("# {0,2} | {1,-21} {2,7} {3,6}     {4,8} {5,-4}", (i+1), (productList[i].name),(productList[i].category), (productList[i].price),"Quanitiy",productList[i].quanity);
            }
            string message = "Would you like to know more about an item ? (y / n)  ";
            Console.Write(message);
            string entry = Console.ReadLine();
            while (entry.ToLower() != "n" || entry.ToLower() != "y" || entry.ToLower() != "no" || entry.ToLower() != "yes")
            {
                if (entry.ToLower() == "n" || entry.ToLower() == "no")
                {
                    Console.Clear();
                    getMainMenu();
                    break;
                }
                else if (entry.ToLower() == "y" || entry.ToLower() == "yes")
                {
                    getItemInfo(productList);
                    Console.ReadKey();
                    Console.Clear();
                    getMainMenu();
                    break;
                }
                else
                {
                    Console.Write($"That is not a valid answer, {message}");
                    entry = Console.ReadLine();
                    continue;
                }
            }
  
        }
        public static void importData(List<Product> list)
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "data.txt");
            FileInfo file = new FileInfo(fileName);

            using (StreamReader sr = new StreamReader(file.FullName))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();

                    strArray = str.Split(',');
                    Product currentProduct = new Product();
                    currentProduct.name = strArray[0];
                    currentProduct.category = (Category)int.Parse(strArray[1]);
                    currentProduct.description = strArray[2];
                    decimal price = 12;
                    if (decimal.TryParse(strArray[3], out price))
                    {
                        currentProduct.price = price;
                    }
                    list.Add(currentProduct);
                    list.Sort();
                }

            }
        }
        public static void OrderFood(ref List<Product> list, ref List<Receipt> receiptList)
        {
            bool goStop = true;
            
            while (goStop == true)
            {
                int x, y,z;
                try
                {
                    Console.Write($"Which item would you like to get? (1 - {list.Count})  ");
                    
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > ((list.Count)))
                    {
                        Console.WriteLine("That is not an option to pick");
                        continue;
                    }
                    else if (x < 1)
                    {
                        Console.WriteLine("That is not a valid option");
                        continue;
                    }

                    y = (x - 1);
                    Console.WriteLine($"The item you are looking at is {list[y].name} ");
                    if (list[y].quanity == 0)
                    {
                        Console.WriteLine($"Sorry, we are out of {list[y].name} please choose something else,");
                        continue;
                    }
                    Console.Write($"They are {list[y].price} an order. We have {list[y].quanity}, how many do you want? ");
                    bool numberStop = true;
                    while (numberStop == true)
                    {
                        try
                        {

                            z = Convert.ToInt32(Console.ReadLine());
                            if (z > ((list[y].quanity)))
                            {
                                Console.WriteLine("we do not have that many, how many would you like?");
                                continue;
                            }
                            else if (z < 1)
                            {
                                Console.WriteLine("That is not a valid option, how many would you like?");
                                continue;
                            }
                            Console.WriteLine($"You will get {z} {list[y].name} for {list[y].price} a piece");
                            list[y].quanity = (list[y].quanity - z);
                            Receipt temp = new Receipt(list[y].name, z, list[y].price);
                            receiptList.Add(temp);
                            numberStop = false;
                        }
                        catch(FormatException)
                        {
                            Console.Write("That is not a valid input, how many would you like? ");
                        }
                    }

                    goStop = Menu.YesNo("Would you like anything else? (y/n) " );

                 }
                catch(FormatException)
                {
                    Console.WriteLine("That is not valid");
                }
                

            }
        }
        public static void getItemInfo(List<Product> list)
        {

            bool goStop = true;
            while (goStop == true)
            {
                int x, y;
                try
                {
                    Console.Write($"Which item would you like to know more about? 1 - {list.Count}. ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > ((list.Count)))
                    {
                        Console.WriteLine("That is not an option to pick");
                        continue;
                    }
                    else if (x < 1)
                    {
                        Console.WriteLine("That is not a valid option");
                        continue;
                    }

                    y = (x - 1);
                    Console.Clear();
                    Console.WriteLine($"The item you are looking at is {list[y].name}\n{ list[y].description}. We have { list[y].quanity} remaining");
                    goStop = false;

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid");
                }

            }
        }
        public static bool YesNo(string message)
        {
            Console.Write(message);
            string entry = Console.ReadLine();
            while (entry.ToLower() != "n" || entry.ToLower() != "y" || entry.ToLower() != "no" || entry.ToLower() != "yes")
            {
                if (entry.ToLower() == "n" || entry.ToLower() == "no")
                {
                    return false;
                }
                else if (entry.ToLower() == "y" || entry.ToLower() == "yes")
                {
                    return true;
                }
                else
                {
                    Console.Write($"That is not a valid answer, {message}");
                    entry = Console.ReadLine();
                    continue;
                }
            }
            Console.WriteLine("This should not be seen.");
            return false;
        }
    }

}
