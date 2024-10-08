using ePet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;


namespace ePet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //linkar na nav-bar o adote
        public ActionResult Adote()
        {
            return View();
        }


        //linkar na nav-bar o home
        public ActionResult Home()
        {
            return View();
        }

        //linkar na nav-bar o disk
        public ActionResult Disk()
        {
            return View();
        }

        //linkar na nav-bar o cadastro
        public ActionResult Cadastro()
        {
            return View();
        }


        //linkar na nav-bar o homeADM
        public IActionResult HomeADM()
        {
            return View();
        }

        //linkar o entrar 
        public ActionResult Entrar()
        {
            return View();
        }

        //linkar tela do perfil do pet com a tela ado��o
        public ActionResult TelaPet()
        {
            return View();
        }

        //linkar tela apadrinhamento
        public ActionResult Apadrinhe()
        {
            return View();
        }

        //Logar usu�rio
        [HttpPost]
        public IActionResult login(string email, string senha)
        {
            Usuarios usuario = new Usuarios(email, senha);
            Usuarios usuarioAutenticado = usuario.logarUsuario(); // Agora retorna o objeto ou null

            if (usuarioAutenticado != null)
            {
                // Verifica se o usu�rio � administrador
                if (usuarioAutenticado.IsAdm == "sim") // Aqui verificamos se o valor � "sim"
                {
                    return RedirectToAction("HomeADM", "Home");
                }
                else // Caso contr�rio, redireciona para a p�gina normal
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            // Se o login falhar, retorna uma mensagem de erro
            ModelState.AddModelError("", "Usu�rio ou senha inv�lidos.");
            return View();
        }


    }
}
