using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 10;
            if (Pizza.Cheese) PizzaPrice += 25;
            if (Pizza.Chicken) PizzaPrice += 50;
            if (Pizza.Paneer) PizzaPrice += 20;
            if (Pizza.Peproni) PizzaPrice += 30;
            if (Pizza.Mushroom) PizzaPrice += 20;
            if (Pizza.Pineapple) PizzaPrice += 100;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}
