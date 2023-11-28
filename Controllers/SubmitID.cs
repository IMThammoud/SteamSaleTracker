using Microsoft.AspNetCore.Mvc;

namespace SteamSalesTracker.Controllers;

public class SubmitId : Controller
{
    [HttpPost("submitId")]
    public ContentResult ReturnWishlist([FromForm] string steamid)
    {
        return Content($"Your Input was: {steamid}", "text/plain");
    }
}