using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ApplicationUI.Controllers
{
    [Authorize]
    public class TestsController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
