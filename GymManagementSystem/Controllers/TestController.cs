using Microsoft.AspNetCore.Mvc;

namespace GymManagementSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
