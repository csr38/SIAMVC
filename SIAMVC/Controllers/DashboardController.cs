using Microsoft.AspNetCore.Mvc;
using SIAMVC.Models;

namespace SIAMVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult DataPastel()
        {
            SeriePastel serie = new SeriePastel();
            return Json(serie.GetDataDummy());
        }
    }
}
