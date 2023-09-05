namespace Product.Order.Models;

public class OrdersList
{
    public string ProductName { get; set; } = string.Empty;
    public int Cost { get; set; }
    public int Qty { get; set; }
    public int Amount { get; set; }
}
