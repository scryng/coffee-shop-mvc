namespace coffee_shop_mvc.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int IdProduct { get; set;}
    public int IdOrder { get; set;}
    public int Quantity { get; set;}
    public Product Product { get; set; }
}