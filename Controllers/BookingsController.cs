using Microsoft.AspNetCore.Mvc;

namespace SurfsUp.Controllers
{
    public class BookingsController : Controller
    {
        public IActionResult Index(int? boardId)
        {
            return View();
        }
    }
}
