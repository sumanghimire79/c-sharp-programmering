using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ILS.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        //Lists all the roles created by users
        public IActionResult Index()

        {
            var roles = _roleManager.Roles;
            return View(roles);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole model)
        {
            //avoid duplicate role

            if (!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {

                _roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }

            return RedirectToAction("Index");
        }
    }
}
