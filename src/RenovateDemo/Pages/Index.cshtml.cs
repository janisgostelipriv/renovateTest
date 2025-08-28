using Humanizer;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RenovateDemo.Pages;

public class IndexModel : PageModel
{
    public string Message { get; private set; } = string.Empty;

    public void OnGet()
    {
        var now = DateTimeOffset.Now;
        Message = $"Willkommen! Die Zeit ist {now} (vor {now.AddMinutes(-42).Humanize()} aktualisiert).";
    }
}
