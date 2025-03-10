using sushiAPI.models;

namespace sushiAPI.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; } = decimal.Zero;

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    }
}
