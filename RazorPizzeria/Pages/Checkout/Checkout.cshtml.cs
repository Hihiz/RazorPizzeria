using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)] /*привязка к полям*/
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationContext _db;

        public CheckoutModel(ApplicationContext db)
        {
            _db = db;
        }

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder pizzaOrder = new PizzaOrder()
            {
                PizzaName = PizzaName,
                BasePrice = PizzaPrice
            };

            _db.PizzaOrders.Add(pizzaOrder);
            _db.SaveChanges();
        }
    }
}
