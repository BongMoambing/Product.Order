namespace Product.Order.Models;

public class Order
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }

    public int Qty { get; set; }
    public int Amount { get; set; }
}
