using ProductManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagmentSystem.Services
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();
        private int currentId = 1;
        public decimal CalculateTotalPrice(decimal price, string category)
        {
            decimal tax = category == "Electrónica" ? 0.10m : 0.05m;
            return price + (price * tax);
        }
        public void AddProduct(string name, decimal price, string category)
        {
            var errors = new List<string>();

            if (FindProductByName(name) != null) errors.Add("El producto ya existe.");
            if (price <= 0) errors.Add("El precio debe ser mayor a 0.");
            if (errors.Any()) throw new ArgumentException(string.Join(Environment.NewLine, errors));

            var totalPrice = this.CalculateTotalPrice(price, category);
            Product newProduct = new Product(currentId++, name, price, category, Math.Round(totalPrice, 2));
            products.Add(newProduct);
        }

        public Product FindProductByName(string name)
        {
            return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
