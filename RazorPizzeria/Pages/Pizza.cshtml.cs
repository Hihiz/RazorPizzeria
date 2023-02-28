using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        private readonly ApplicationContext _db;

        public PizzaModel(ApplicationContext db)
        {
            _db = db;
        }

        public List<PizzasModel> pizzasModels = new List<PizzasModel>();

        public List<PizzasModel> pizzaModelDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle="BIANCA",
                PizzaName="Bianca",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=8
            },
            new PizzasModel()
            {
                ImageTitle="Caesar",
                PizzaName="Caesar",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice=10
            },
            new PizzasModel()
            {
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                Mushroom=true,
                FinalPrice=17
            },
            new PizzasModel()
            {
                ImageTitle="Cheese",
                PizzaName="Cheese",
                BasePrice=2,
                Cheese=true,
                FinalPrice=7
            },
            new PizzasModel()
            {
                ImageTitle="Favorite",
                PizzaName="Favorite",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                Tuna=true,
                Mushroom=true,
                FinalPrice=25
            },
            new PizzasModel()
            {
                ImageTitle="Green",
                PizzaName="Green",
                BasePrice=2,
                TomatoSauce=true,
                Beef=true,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                Pineapple=true,
                FinalPrice=22
            },
            new PizzasModel()
            {
                ImageTitle="Homelike",
                PizzaName="Homelike",
                BasePrice=2,
                Cheese=true,
                Beef=true,
                FinalPrice=9
            },
            new PizzasModel()
            {
                ImageTitle="MEAT",
                PizzaName="MEAT",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                Tuna=true,
                Mushroom=true,
                Ham=true,
                Peperoni=true,
                FinalPrice=59
            },
            new PizzasModel()
            {
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Peperoni=true,
                FinalPrice=48
            },
            new PizzasModel()
            {
                ImageTitle="VILLAGE",
                PizzaName="Village",
                BasePrice=2,
                Tuna=true,
                Mushroom=true,
                Peperoni=true,
                FinalPrice=17
            }
        };

        public void OnGet()
        {
            pizzasModels = _db.PizzasModels.ToList();
        }
    }
}
