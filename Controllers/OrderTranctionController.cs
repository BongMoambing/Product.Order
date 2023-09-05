using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Product.Order.DataService;
using Product.Order.Models;
using System.Linq;

namespace Product.Order.Controllers;

public class OrderTranctionController : Controller
{
    private ISqlDataAccessLayer _db;
    public OrderTranctionController(ISqlDataAccessLayer db)
    {
        _db = db;
    }
    public IActionResult GetOrderList()
    {
        return View();
    }

    public async Task<IActionResult> GetById(int id)
    {
       
        var product = await _db.LoadData<Products, dynamic>("exam.spProductById", new { @ProductId = id });

        return View(product.FirstOrDefault());
    }
}
