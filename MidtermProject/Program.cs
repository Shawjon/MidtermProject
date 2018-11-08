using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Product> productsList = new List<Product>();
            List<Receipt> receipts = new List<Receipt>();
            Menu.importData(productsList);
            int x;
            bool yesNo = true;
            while (yesNo == true)
            {
                try
                {
                    Menu.getMainMenu();
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                    {
                        Console.Clear();
                        Menu.PrintList(productsList);
                        continue;
                    }
                    else if (x == 2)
                    {
                        Menu.OrderFood(ref productsList, ref receipts);
                        Console.Clear();
                        Receipt.getTotal(receipts);
                        receipts.Clear();
                        Console.ReadKey();
                        Console.Write("Enter in a creditcard number: ");
                        string creditcard = Validator.ValidateCreditCardNumber();
                        Console.Write("Enter in the security code: ");
                        string cvv = Validator.ValidateCVV();
                        Console.Write("Enter in the epiration date (00/00): ");
                        string Exp = Validator.ValidateExpiration();
                        Console.WriteLine($"{creditcard} CVV:{cvv}. Expiration: {Exp}. ");
                        
                        
                        Console.ReadKey();
                        continue;
                    }
                    else if (x == 3)
                    {
                        Console.WriteLine("Have a good day!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid choice, try again");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input");
                }
            }

           

        }
        
    }
}

