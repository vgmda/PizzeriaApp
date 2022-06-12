using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzeriaApp.Models;

namespace PizzeriaApp.Pages.Shared
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margherita",
                PizzaName="Margherita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true}
        };

        public void OnGet()
        {
        }
    }
}
