using Microsoft.AspNetCore.Mvc;

namespace Tactsoft.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
