using ECommerceStore.Models;

namespace ECommerceStore.Services
{
    public class OrderService
    {
        private Product? selectedProduct;
        private Order? lastOrder;

        public void SetSelectedProduct(Product product)
        {
            selectedProduct = product;
        }

        public Product? GetSelectedProduct()
        {
            return selectedProduct;
        }

        public void PlaceOrder(Order order)
        {
            lastOrder = order;
        }

        public Order? GetLastOrder()
        {
            return lastOrder;
        }
    }
}