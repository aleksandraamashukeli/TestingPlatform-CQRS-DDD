using Microsoft.AspNetCore.Mvc;

namespace ApplicationUI.Controllers
{
    public class HomeController :Controller
    {
        public IActionResult Index() => View();
    }
}
