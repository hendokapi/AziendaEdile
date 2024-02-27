using AziendaEdile.Models;
using Microsoft.AspNetCore.Mvc;

namespace AziendaEdile.Controllers
{
    public class PagamentoController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDbPagamenti.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.dipendenti = StaticDbDipendenti.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Pagamento pagamento)
        {
            StaticDbPagamenti.Add(pagamento);
            return RedirectToAction("Index");
        }
    }
}
