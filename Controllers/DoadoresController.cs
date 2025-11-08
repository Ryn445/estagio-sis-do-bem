using Microsoft.AspNetCore.Mvc;
using SisDoBem.Models;

namespace SisDoBem.Controllers
{
    public class DoadoresController : Controller
    {
        public IActionResult Index()
        {
            // Aqui futuramente vamos carregar os dados dos doadores
            return View();
        }

        public IActionResult Create()
        {
            // Exibe o formulário de cadastro de novo doador
            return View();
        }
    }
}
