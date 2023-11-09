using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemLendSystemWithLogin.Controllers
{
    public class CPanelController : Controller
    {
        // GET: CPanelController
        [Authorize(Roles = "Admin")]
        public ActionResult CPanel()
        {
            return View();
        }

    }
}
