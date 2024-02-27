using AziendaEdile.Models;
using Microsoft.AspNetCore.Mvc;

namespace AziendaEdile.Controllers
{
    public class DipendenteController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDbDipendenti.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Dipendente dipendente)
        {
            var newDipendente = StaticDbDipendenti.Add(dipendente);
            var newDipendenteId = newDipendente.DipendenteId;
            return RedirectToAction("Index");
            //return RedirectToAction("Details", new { id = newDipendenteId });
        }
    }
}
