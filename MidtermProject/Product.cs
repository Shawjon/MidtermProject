﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Product:IComparable<Product>
    {
        private string Name;
        private Category Category;
        private string Description;
        private decimal Price;
        private int Quantity;
       
        public Product()
        {
            Quantity = 50;
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
        public int CompareTo(Product temp)
        {

            if (this.Category == temp.Category)
            {
                return this.Name.CompareTo(temp.Name);
            }
            return this.Category.CompareTo(temp.Category);
        }

    }
}
