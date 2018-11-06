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
            //Product product1 = new Product("Fired Chicken Bao", 0, "Fried Chicken and a pickle on a steamed bun", 4);
            //Product product2 = new Product("Pork Chashu Bao", 0, "Marinated pork belly on a steamed bun", 4);
            //Product product3 = new Product("Pork Gyoza", 0, "Fried dumplings with a pork and vegtable filling", 6);
            //List<Product> productsList = new List<Product> { product1, product2, product3 };

            //string line;
            List<Product> productsList = new List<Product>();

            //// Read the file and display it line by line.
            //System.IO.StreamReader file =
            //    new System.IO.StreamReader(@"C:\Users\jshaw2\source\repos\MidtermProject\MidtermProject\data.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    string[] input = line.Split(',');
            //    productsList.Add(new Product(input[0], (Category)int.Parse(input[1]), input[2],decimal.Parse(input[3])));
            //}

            //file.Close();

            ///Stream path = @"C:\Users\jshaw2\source\repos\MidtermProject\MidtermProject\data.txt";
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
                    //currentProduct.price = int.TryParse(strArray[3], out);

                    productsList.Add(currentProduct);


                }

                Menu.getMainMenu();
                Menu.PrintList(productsList);

                Console.ReadLine();

            }
        }
    }
}
