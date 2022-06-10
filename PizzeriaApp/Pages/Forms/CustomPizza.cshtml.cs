using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzeriaApp.Models;

namespace PizzeriaApp.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {

        [BindProperty]
        // Create reference to the actual PizzasModel
        public PizzasModel Pizza { get; set; }

        public void OnGet()
        {
        }
    }
}
