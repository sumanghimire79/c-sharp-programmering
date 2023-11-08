using Microsoft.AspNetCore.Mvc;

namespace ItemLendSystemWithLogin.Controllers
{
    public class ControlPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
