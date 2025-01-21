using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp1.Pages;

public class RazorModel : PageModel
{
    private readonly ILogger<RazorModel> _logger;

    public RazorModel(ILogger<RazorModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

