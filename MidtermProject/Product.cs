using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Product
    {
        private string Name;
        private Category Category;
        private string Description;
        private decimal Price;
        private int Quantity;
       
        public Product()
        {
        }
        public Product(string name,Category category, string description, decimal price)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            Quantity = 50;
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
        public Category category
        {
            set
            {
                Category = value;
            }
            get
            {
                return Category;
            }
        }
        public string description
        {
            set
            {
                Description = value;
            }
            get
            {
                return Description;
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

    }
}
