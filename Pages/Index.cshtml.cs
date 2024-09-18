using Microsoft.AspNetCore.Mvc.RazorPages;
using YourNamespace.Models; // Adjust the namespace to match your project

namespace YourNamespace.Pages
{
    public class IndexModel : PageModel
    {
        public required FizzBuzzModel FizzBuzz { get; set; }

        public void OnGet()
        {
            FizzBuzz = new FizzBuzzModel();
        }
    }
}
