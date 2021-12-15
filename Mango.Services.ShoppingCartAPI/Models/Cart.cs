namespace Mango.Services.ShoppingCartAPI.Models
{
    public class Cart
    {
        public CartHeader CardHeader { get; set; }
        
        public IEnumerable<CartDetails> CartDetails { get; set; }

    }
}
