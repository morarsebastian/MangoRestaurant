namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDto
    {
        public CartHeaderDto CardHeader { get; set; }
        
        public IEnumerable<CartDetailsDto> CartDetails { get; set; }

    }
}
