using Microsoft.AspNetCore.Mvc;

namespace SteamSalesTracker.Controllers;

public class IndexController : Controller
{
    [HttpGet("index")]
    public IActionResult LoadHtmlPage()
    {
        return Redirect("/index.cshtml");
    }
}