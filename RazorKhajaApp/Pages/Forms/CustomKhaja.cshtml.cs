using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorKhajaApp.Models;

namespace RazorKhajaApp.Pages.Forms
{
    public class CustomKhajaModel : PageModel
    {

        [BindProperty]
        public KajasModel Khaja { get; set; }
        public void OnGet()
        {
        }
    }
}
