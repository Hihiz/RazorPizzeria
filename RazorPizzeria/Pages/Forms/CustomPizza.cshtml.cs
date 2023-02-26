using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty] /*привязка*/
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 5;
            if (Pizza.Peperoni) PizzaPrice += 2;
            if (Pizza.Mushroom) PizzaPrice += 7;
            if (Pizza.Tuna) PizzaPrice += 4;
            if (Pizza.Peperoni) PizzaPrice += 20;
            if (Pizza.Ham) PizzaPrice += 20;
            if (Pizza.Beef) PizzaPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}