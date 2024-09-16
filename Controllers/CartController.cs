using Microsoft.AspNetCore.Mvc;
using SurfsUp.Models;

namespace SurfsUp.Controllers
{
    public class CartController : Controller
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IBoardRepository _boardRepository;

        public CartController(IBookingRepository bookingRepository, IBoardRepository boardRepository)
        {
            _bookingRepository = bookingRepository;
            _boardRepository = boardRepository;
        }

        public async Task<IActionResult> Index()
        {
            // Assuming you have a way to identify the current user (e.g., User.Identity.Name or session)
            var userId = User.Identity.Name;

            // Fetch bookings for the current user
            var bookings = await _bookingRepository.GetAllBookings();

            return View(bookings);
        }
    }
}
