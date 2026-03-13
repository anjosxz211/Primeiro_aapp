using Microsoft.AspNetCore.Mvc;

namespace Primeiro_APP.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno Nota 10";
            ViewData["Escola"] = "E.E. Anhanguera";
            return View();
        }
    }
}
