using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages
{
    public class PizzeriaModel : PageModel
    {
        public List<PizzasModel> fakeDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="1",
                PizzaName="Margerita",
                BasePrice=30,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=65
            },
            new PizzasModel(){
                ImageTitle="2",
                PizzaName="Hawaiian",
                BasePrice=30,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=65
            },
            new PizzasModel(){
                ImageTitle="3",
                PizzaName="Chicken",
                BasePrice=40,
                TomatoSauce=true,
                Cheese=true,
                Chicken=true,
                FinalPrice=125
            },
            new PizzasModel(){
                ImageTitle="4",
                PizzaName="Paneer",
                BasePrice=30,
                TomatoSauce=true,
                Cheese=true,
                Paneer=true,
                FinalPrice=85
            },
            new PizzasModel(){
                ImageTitle="5",
                PizzaName="Peproni",
                BasePrice=30,
                TomatoSauce=true,
                Cheese=true,
                Peproni=true,
                FinalPrice=95
            },
            new PizzasModel(){
                ImageTitle="6",
                PizzaName="Mushroom",
                BasePrice=30,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=85
            },
            new PizzasModel(){
                ImageTitle="7",
                PizzaName="Italian",
                BasePrice=30,
                TomatoSauce=true,
                Cheese=true,
                Chicken=true,
                Peproni=true,
                FinalPrice=145
            },
            new PizzasModel(){
                ImageTitle="8",
                PizzaName="Pineapple",
                BasePrice=30,
                TomatoSauce=true,
                Cheese=true,
                Pineapple=true,
                FinalPrice=165
            },
            new PizzasModel(){
                ImageTitle="9",
                PizzaName="ROYAL",
                BasePrice=40,
                TomatoSauce=true,
                Cheese=true,
                Chicken=true,
                Peproni=true,
                Paneer=true,
                Mushroom=true,
                FinalPrice=450
            }


        };
        public void OnGet()
        {
        }
    }
}
