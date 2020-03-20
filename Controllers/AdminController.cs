using Microsoft.AspNetCore.Mvc;

namespace ASPCORE.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return Content("Exibindo painel admin");
        }

        public IActionResult Teste()
        {
            return Content("Resultado do teste");
        }
    }

}