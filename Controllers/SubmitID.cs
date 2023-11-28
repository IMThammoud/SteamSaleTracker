using Microsoft.AspNetCore.Mvc;

namespace SteamSalesTracker.Controllers;

public class SubmitId
{
    [HttpPost("submitId")]
    public string returnWishlist([FromForm] string steamid)
    {
        return steamid + ": This was your SteamID ";
    }
}