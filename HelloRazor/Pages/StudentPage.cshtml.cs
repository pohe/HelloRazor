using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloRazor.Pages
{
    public class StudentPageModel : PageModel
    {
        public string Greeting { get; set; }                

        public StudentPageModel()
        {
            
        }
        public void OnGet()
        {
            Greeting = "Dette er en lille hilsen";
        }
    }
}
