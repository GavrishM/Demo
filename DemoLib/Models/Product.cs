using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
        public string Parts { get; set; }
        public double Price { get; set; }
        public string Supplier { get; set; }
        public string ImagePath { get; set; }
        public Product() { }
        public Product(string name,
                       string category,
                       int count,
                       string parts,
                       double price,
                       string supplier,
                       string imagePath)
        {
            Name = name;
            Category = category;
            Count = count;
            Parts = parts;
            Price = price;
            Supplier = supplier;
            ImagePath = imagePath;
        }
    }
}
