using Microsoft.AspNetCore.Mvc;

namespace ASPCORE.Controllers
{
    [Route("painel/admin")]
    public class AdminController : Controller
    {
        [HttpGet("")]
        [HttpGet("principal")]
        public IActionResult Index()
        {
            return Content("Exibindo painel admin");
        }

        [HttpGet("teste")]
        public IActionResult Teste()
        {
            return Content("Resultado do teste");
        }
    }

}