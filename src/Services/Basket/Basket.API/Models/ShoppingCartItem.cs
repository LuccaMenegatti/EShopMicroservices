namespace Basket.API.Models;

public class ShoppingCartItem
{
    public int Quantity { get; set; } = default!;
    public string Color { get; set; } = string.Empty;
    public decimal Price { get; set; } = decimal.Zero;
    public Guid ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
}