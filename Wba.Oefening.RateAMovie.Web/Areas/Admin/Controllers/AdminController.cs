using Microsoft.AspNetCore.Mvc;

namespace Wba.Oefening.RateAMovie.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
