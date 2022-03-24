using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_ef_2022.Pages;

public class PrivacyModel : PageModel
{
    public String Message {get; private set;} = "Message!";
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Message += $"Time is {DateTime.Now}";
    }
   
}

