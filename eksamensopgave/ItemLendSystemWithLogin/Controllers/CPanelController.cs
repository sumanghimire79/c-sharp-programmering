using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemLendSystemWithLogin.Controllers
{
    public class CPanelController : Controller
    {
        // GET: CPanelController
        [Authorize(Roles = "Admin")]
        //[Authorize]
        public ActionResult CPanel()
        {
            return View();
        }

    }
}
