using Product.Order.Models;

namespace Product.Order.ViewModel;

public class OrderDetails
{
    public Products ProductList { get; set; }
    public IEnumerable<OrdersList> OrderItem { get; set; }
    public Payment PaymentInfo { get; set; }
    
}
