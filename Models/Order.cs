using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace coffee_shop_mvc.Models;

public class Order
{
    public int Id { get; set; }

    [Required]
    public DateTime TimeStamp { get; set; }

    [Range(0, double.MaxValue)]
    public decimal TotalPrice { get; set; }

    // Relação um para muitos com OrderItem
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
