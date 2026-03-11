using Microsoft.AspNetCore.Mvc;

namespace Primeiro_APP.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
