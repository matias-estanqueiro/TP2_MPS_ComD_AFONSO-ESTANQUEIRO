using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagmentSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public decimal TotalPrice { get; private set; }

        public Product(int id, string name, decimal price, string category, decimal totalPrice)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            TotalPrice = totalPrice;
        }
    }
}
