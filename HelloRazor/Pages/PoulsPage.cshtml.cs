using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloRazor.Pages
{
    public class PoulsPageModel : PageModel
    {

        public string Name { get; set; }

        public PoulsPageModel()
        {
            Name = "Poul";
        }
        public void OnGet()
        {
        }
    }
}
