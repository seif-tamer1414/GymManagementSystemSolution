using GymManagementSystem.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagementSystem.Controllers
{
    public class PlanController : Controller
    {
        private GymDbContext dbContext = new GymDbContext();
        public async Task<IActionResult> Index()
        {
            var Plans = await dbContext.Plans.ToListAsync();
            return View(Plans);
        }
    }
}
