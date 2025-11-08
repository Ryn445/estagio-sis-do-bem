using Microsoft.AspNetCore.Mvc;
using SisDoBem.Models;

namespace SisDoBem.Controllers
{
    public class DonatariosController : Controller
    {
        public IActionResult Index()
        {
            // Aqui futuramente vamos carregar os dados dos donatários
            return View();
        }

        public IActionResult Create()
        {
            // Exibe o formulário de cadastro de novo donatário
            return View();
        }
    }
}
