using ProductManagmentSystem.Models;
using ProductManagmentSystem.Services;


namespace ProductManagmentSystemTest
{
    public class Tests
    {
        [TestFixture]
        public class ProductManagerTests
        {
            private ProductManager productManager;

            [SetUp]
            public void Setup()
            {
                productManager = new ProductManager();
            }

            [Test]
            public void CreateProduct_ValidParameters_ProductCreatedSuccessfully()
            {
                int id = 1;
                string name = "Laptop";
                decimal price = 1000.00m;
                string category = "Electrónica";
                decimal totalPrice = price + (price * 0.10m);

                var product = new Product(id, name, price, category, Math.Round(totalPrice, 2));

                Assert.Multiple(() =>
                {
                    Assert.That(id, Is.EqualTo(product.Id));
                    Assert.That(name, Is.EqualTo(product.Name));
                    Assert.That(price, Is.EqualTo(product.Price));
                    Assert.That(category, Is.EqualTo(product.Category));
                    Assert.That(Math.Round(totalPrice, 2), Is.EqualTo(product.TotalPrice));
                });
            }

            [Test]
            public void AddProduct_ValidProduct_ProductAddedSuccessfully()
            {
                string name = "Smartphone";
                decimal price = 500.00m;
                string category = "Electrónica";

                int initialCount = productManager.GetAllProducts().Count;
                productManager.AddProduct(name, price, category);
                int newCount = productManager.GetAllProducts().Count;
                Assert.That(newCount, Is.EqualTo(initialCount + 1), "La cantidad de productos no aumentó como se esperaba.");
                Product addedProduct = productManager.GetAllProducts().Last();
                
                Assert.Multiple(() =>
                {
                    Assert.That(addedProduct.Name, Is.EqualTo(name));
                    Assert.That(addedProduct.Price, Is.EqualTo(price));
                    Assert.That(addedProduct.Category, Is.EqualTo(category));
                });
            }

            [Test]
            public void FindProductByName_ProductExists_ProductFound()
            {
                productManager.AddProduct("Tablet", 300.00m, "Electrónica");
                productManager.AddProduct("Headphones", 150.00m, "Electrónica");

                Product product = productManager.FindProductByName("Tablet");

                Assert.That(product, Is.Not.Null);
                Assert.That(product.Name, Is.EqualTo("Tablet"));
            }

            [Test]
            public void CalculateTotalPrice_ElectronicsCategory_CorrectTotalPrice()
            {
                decimal price = 1000.00m;
                string category = "Electrónica";
                decimal expectedTotalPrice = price + (price * 0.10m);

                decimal actualTotalPrice = productManager.CalculateTotalPrice(price, category);

                Assert.That(Math.Round(expectedTotalPrice, 2), Is.EqualTo(actualTotalPrice));
            }

            [Test]
            public void CalculateTotalPrice_FoodCategory_CorrectTotalPrice()
            {
                decimal price = 100.00m;
                string category = "Alimentos";
                decimal expectedTotalPrice = price + (price * 0.05m);

                decimal actualTotalPrice = productManager.CalculateTotalPrice(price, category);

                Assert.That(Math.Round(expectedTotalPrice, 2), Is.EqualTo(actualTotalPrice));
            }
        }
    }
}