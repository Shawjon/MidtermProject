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

            Console.WriteLine($"Sub Total: ${subTotal}");
            Console.WriteLine($"Tax: ${taxAmount.ToString(".00")}");
            Console.WriteLine($"Grand Total: ${grandTotal.ToString(".00")}");
            
        }
        public static void getPayment()
        {
           
            int x;
            bool yesNo = true;
            while (yesNo == true)
            {
                try
                {
                    Console.WriteLine("How would you like to pay?");
                    Console.WriteLine("1. By Cash.");
                    Console.WriteLine("2. By Credit Card.");
                    Console.WriteLine("3. By Check.");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                    {
                        
                        continue;
                    }
                    else if (x == 2)
                    {
                        string creditCardNumber = Validator.ValidateCreditCardNumber();
                        string expiration = Validator.ValidateExpiration();
                        string CVV = Validator.ValidateCVV();
                        continue;
                    }
                    else if (x == 3)
                    {

                        continue;
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
