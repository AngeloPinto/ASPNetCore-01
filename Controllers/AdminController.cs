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

        [HttpGet("nome/{nome}")]
        public IActionResult Nome(string nome) 
        {
            return Content("Olá " + nome + "!!!");
        }

        [HttpGet("idade/{idade:int}")]
        public IActionResult Idade(int idade)
        {
            return Content("Sua idade é : " + idade);
        }
    }

}