using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzeriaApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]

    public class CheckoutModel : PageModel
    {

        public string PizzaName { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }

        public void OnGet()
        {
            // Validation - If the name of the pizza is not entered, set it to 'Custom'
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            // Validation - If the image path for the pizza is not provided, set it to 'Create.png'
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
