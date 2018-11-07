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
    }
}
