using System.ComponentModel.DataAnnotations;

namespace Product.Order.Models;
public class Products
{
    [Key]
    public int ProductId { get; set; }

    public string ProductName { get; set; } = string.Empty;
    public int Cost { get; set; }
        

}
