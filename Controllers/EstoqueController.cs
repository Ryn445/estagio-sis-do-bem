using Microsoft.AspNetCore.Mvc;

namespace SisDoBem.Controllers
{
    public class EstoqueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
