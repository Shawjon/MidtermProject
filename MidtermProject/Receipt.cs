using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Receipt
    {
        private string Name;
        private decimal Price;
        private int Quantity;

        public Receipt()
        {
        }
        public Receipt(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public string name
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }
        public decimal price
        {
            set
            {
                Price = value;
            }
            get
            {
                return Price;
            }
        }
        public int quanity
        {
            set
            {
                Quantity = value;
            }
            get
            {
                return Quantity;
            }
        }
        public static void getTotal(List<Receipt> list)
        {
            decimal subTotal = 0;
            decimal taxAmount = 0;
            decimal grandTotal = 0;
            decimal salesTax = .06m;
            for (int i = 0; i < list.Count; i++)
            {
                decimal linePrice = list[i].price * list[i].quanity;
                subTotal = subTotal + linePrice;
                Console.WriteLine($"{list[i].quanity} {list[i].name} at {list[i].price} = {linePrice}");
            }
            taxAmount = (subTotal * salesTax);
            grandTotal = (subTotal + taxAmount);
            Console.WriteLine("\n");
            Console.WriteLine($"Sub Total: ${subTotal}");
            Console.WriteLine($"Tax: ${taxAmount.ToString(".00")}");
            Console.WriteLine($"Grand Total: ${grandTotal.ToString(".00")}");
            Console.ReadKey();
            
        //}
        //public static void getPayment(List<Receipt> list)
        //{
           
            
            bool yesNo = true;
            while (yesNo == true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("How would you like to pay?");
                    Console.WriteLine("1. By Cash.");
                    Console.WriteLine("2. By Credit Card.");
                    Console.WriteLine("3. By Check.");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                    {
                        Console.Write("How much cash are you paying with? ");
                        decimal cash = Validator.ValidateCash();
                        while (cash < grandTotal)
                        {
                            Console.WriteLine("That is not enough to cover the bill, please provide enough money to cover the bill. ");
                            cash = Validator.ValidateCash();
                        }
                        decimal change = cash - grandTotal;


                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------------\n" +
                                          "|   Thank you for getting your event catered by        |\n" +
                                          "|         Roaming Ramen! Here is your Reciept          |\n" +
                                          "--------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine($"Sub Total: ${subTotal}");
                        Console.WriteLine($"Tax: ${taxAmount.ToString(".00")}");
                        Console.WriteLine($"Grand Total: ${grandTotal.ToString(".00")}");
                        //Receipt.getTotal(list);
                        Console.WriteLine();
                        Console.WriteLine($"You paid with cash.");
                        Console.WriteLine($"Total: ${grandTotal.ToString(".00")}\nReceived: ${cash}\nChange: ${change.ToString(".00")}");
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------------\n" +
                                          "|                Please come again!                    |\n" +
                                          "|                                                      |\n" +
                                          "--------------------------------------------------------");
                        Console.WriteLine("\n");
                        Console.ResetColor();

                        break;
                    }
                    else if (x == 2)
                    {
                        Console.Write("What is your Credit Card Number? (13-16 digits) ");
                        string creditCardNumber = Validator.ValidateCreditCardNumber();
                        Console.Write("What is the Expiration? (MM/YY) ");
                        string expiration = Validator.ValidateExpiration();
                        Console.Write("What is the Security Code? (###) ");
                        string CVV = Validator.ValidateCVV();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------------\n" +
                                          "|   Thank you for getting your event catered by        |\n" +
                                          "|         Roaming Ramen! Here is your Reciept          |\n" +
                                          "--------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine($"Sub Total: ${subTotal}");
                        Console.WriteLine($"Tax: ${taxAmount.ToString(".00")}");
                        Console.WriteLine($"Grand Total: ${grandTotal.ToString(".00")}");
                       // Receipt.getTotal(list);
                        Console.WriteLine();
                        Console.WriteLine($"You paid using your Credit card ending in {creditCardNumber}\n");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------------\n" +
                                          "|                Please come again!                    |\n" +
                                          "|                                                      |\n" +
                                          "--------------------------------------------------------");
                        Console.WriteLine("\n");
                        Console.ResetColor();

                        break;
                    }
                    else if (x == 3)
                    {
                        Console.Write("What is your Checking Account Number? (9 digits) ");
                        string AccountNumber = Validator.ValidateRoutingAccountNumber();
                        Console.Write("What is the Bank Routing Number? (9 digits) ");
                        string RoutingNumber = Validator.ValidateRoutingAccountNumber();
                        
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------------\n" +
                                          "|   Thank you for getting your event catered by        |\n" +
                                          "|         Roaming Ramen! Here is your Reciept          |\n" +
                                          "--------------------------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine($"Sub Total: ${subTotal}");
                        Console.WriteLine($"Tax: ${taxAmount.ToString(".00")}");
                        Console.WriteLine($"Grand Total: ${grandTotal.ToString(".00")}");
                        //Receipt.getTotal(list);
                        Console.WriteLine();
                        Console.WriteLine($"You paid with a check\nAccount Number - {AccountNumber}. Rounting Number - {RoutingNumber}.\n");
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------------\n" +
                                          "|                Please come again!                    |\n" +
                                          "|                                                      |\n" +
                                          "--------------------------------------------------------");
                        Console.WriteLine("\n");
                        Console.ResetColor();

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
