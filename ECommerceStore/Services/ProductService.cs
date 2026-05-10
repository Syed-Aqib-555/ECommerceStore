using ECommerceStore.Models;

namespace ECommerceStore.Services
{
    public class ProductService
    {
        private List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 120000,
                ImageUrl = "https://via.placeholder.com/300x200?text=Laptop"
            },
            new Product
            {
                Id = 2,
                Name = "Smart Phone",
                Price = 80000,
                ImageUrl = "https://via.placeholder.com/300x200?text=Phone"
            },
            new Product
            {
                Id = 3,
                Name = "Headphones",
                Price = 15000,
                ImageUrl = "https://via.placeholder.com/300x200?text=Headphones"
            },
            new Product
            {
                Id = 4,
                Name = "Smart Watch",
                Price = 25000,
                ImageUrl = "https://via.placeholder.com/300x200?text=Watch"
            }
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product? GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}