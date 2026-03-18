using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Pkcs;

namespace Primeiro_APP.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno Anhanguera MB";
            ViewData["Escola"] = "E.E. Anhanguera";
            return View();
        }
        public IActionResult Teste()
        {
            TempData["MSG_EX"] = "Mensagem do TempData";
            return RedirectToAction("Resultado");
        }
        public IActionResult Resultado()
        {
            if (TempData["MSG_EX"] != null)
                ViewBag.Exemplo = "Aluno Anhanguera MB";
            return View();
        }
    }
}