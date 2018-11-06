using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Fired Chicken Bao", 0, "Fried Chicken and a pickle on a steamed bun", 4);
            Product product2 = new Product("Pork Chashu Bao", 0, "Marinated pork belly on a steamed bun", 4);
            Product product3 = new Product("Pork Gyoza", 0, "Fried dumplings with a pork and vegtable filling", 6);

            List<Product> productList = new List<Product> { product1, product2, product3 };

            foreach (Product product in productList)
            {
                Console.WriteLine($"{product.name}, A {product.category} that costs ${product.price}. {product.description}. We have {product.quanity} ");
            }
            Console.ReadLine();

        }
    }
}
