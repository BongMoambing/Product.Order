using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Product.Order.DataService;
using Product.Order.Models;
using Product.Order.ViewModel;
using System.Linq;

namespace Product.Order.Controllers;

public class OrderTranctionController : Controller
{
    private ISqlDataAccessLayer _db;
    public OrderTranctionController(ISqlDataAccessLayer db)
    {
        _db = db;
    }
    public async Task<IActionResult> GetOrderList()
    {
        OrderDetails details = new OrderDetails();
        details.OrderItem = (IEnumerable<OrdersList>)await GetOrders();
        return View(details);
    }

    public async Task<IActionResult> GetById(int id)
    {
       
        var product = await _db.LoadData<Products, dynamic>("exam.spProductById", new { @ProductId = id });

        return View(product.FirstOrDefault());
    }

    public async Task<IActionResult> GetOrders()
    {

        var product = await _db.LoadData<OrdersList, dynamic>("spOrderGetList", new { });

        return View(product.ToList());
    }
}
