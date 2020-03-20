using System;
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

        [HttpGet("fone")]
        public IActionResult Fone()
        {

            // Example.: https://localhost:5001/painel/admin/fone?ddd=92&fone=7894-4563
            
            int    ddd  = Convert.ToInt32(Request.Query["ddd"]);
            string fone = Request.Query["fone"];
           
            return Content($"Seu telefone para contato é : ({ddd}) {fone}");
        }


        [HttpGet("visualizar/{nome?}")]
        public IActionResult Visualizar(string nome = "") 
        {
            ViewData["nome"] = nome;
            return View();
        }

    } // CLASS

} // NAMESPACE
