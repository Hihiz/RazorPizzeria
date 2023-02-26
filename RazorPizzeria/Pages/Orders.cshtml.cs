using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrder = new List<PizzaOrder>();

        private readonly ApplicationContext _db;

        public OrdersModel(ApplicationContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            PizzaOrder = _db.PizzaOrders.ToList();
        }
    }
}
