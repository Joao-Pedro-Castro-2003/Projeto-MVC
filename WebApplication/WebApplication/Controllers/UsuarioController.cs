using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
