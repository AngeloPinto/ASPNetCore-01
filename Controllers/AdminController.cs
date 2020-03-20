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

        [HttpGet("nome/{nome:?}")]
        public IActionResult Nome(string nome = "")
        {
            if (!nome.Equals("")) 
            {
                return Content("Olá " + nome + "!!!");
            } else 
            {
                return Content("Você não informou seu nome :(");
            }
            
        }

        [HttpGet("idade/{idade:int}")]
        public IActionResult Idade(int idade)
        {
            return Content("Sua idade é : " + idade);
        }

        [HttpGet("pessoa/{nome}/{idade:int}")]
        public IActionResult Pessoa(string nome, int idade)
        {
            return Content($"Olá {nome}!!! Você tem {idade} anos de idade");
        }
    }

}