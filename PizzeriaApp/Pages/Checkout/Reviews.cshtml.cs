using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzeriaApp.Pages.Checkout;


public class ThankYouModel : PageModel
{
    public string PizzaName { get; set; }



    public void OnGet()
    {

    }
}
