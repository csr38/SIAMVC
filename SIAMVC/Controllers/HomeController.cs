using Microsoft.AspNetCore.Mvc;
using SIAMVC.Models;
using System.Diagnostics;

namespace SIAMVC.Controllers
{
    public class HomeController : Controller
    {
        private RegistroReportes _context;

        public HomeController(RegistroReportes c)
        {
            _context = c;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HumedalElqui()
        {

            return View();
        }

        public IActionResult HumedalElCulebron()
        {

            return View();
        }

        public IActionResult VerDenuncias()
        {
            var datos = _context.Datos.ToList();
            return View(datos);
        }


        public IActionResult Denuncias()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult Denuncias(Reporte n)
        {
            if (ModelState.IsValid)
            {
                _context.Add(n);
                _context.SaveChanges();

                return RedirectToAction("VerDenuncias");
            }
            else
            {
                return View(n);
            }

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}