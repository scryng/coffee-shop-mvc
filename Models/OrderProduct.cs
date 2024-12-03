using System.ComponentModel.DataAnnotations;

namespace coffee_shop_mvc.Models;

public class OrderProduct
{
    public int Id { get; set; }

    // Chave estrangeira para Product
    [Required]
    public int IdProduct { get; set; }

    public Product Product { get; set; } // Navegação para Product

    // Chave estrangeira para Order
    [Required]
    public int IdOrder { get; set; }

    public Order Order { get; set; } // Navegação para Order

    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
    public int Quantity { get; set; }
}
