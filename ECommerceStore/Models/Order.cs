namespace ECommerceStore.Models
{
    public class Order
    {
        public string CustomerName { get; set; } = "";
        public string Address { get; set; } = "";
        public string ContactNumber { get; set; } = "";
        public int Quantity { get; set; } = 1;

        public Product? Product { get; set; }

        public decimal TotalPrice =>
            Product != null ? Product.Price * Quantity : 0;
    }
}