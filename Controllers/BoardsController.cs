using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using SurfsUp.Data;
using SurfsUp.Models;

namespace SurfsUp.Controllers
{
    public class BoardsController : Controller
    {
        private readonly IBoardRepository _boardRepository;
        private readonly IBookingRepository _bookingRepository;
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BoardsController(IBoardRepository boardRepository, IBookingRepository bookingRepository, AppDbContext context, UserManager<AppUser> userManager)
        {
            _boardRepository = boardRepository;
            _bookingRepository = bookingRepository;
            _context = context;
            _userManager = userManager;

        }

        public async Task<IActionResult> Index()
        {
            var boards = await _boardRepository.GetAllBoards();
            
            return View(boards);
        }

        //KEVIN

        // Handle booking submission
        [HttpPost]
        public async Task<IActionResult> Book(int boardId, DateTime dateFrom, DateTime dateTo)
        {
            var board = await _boardRepository.GetBoardById(boardId);
            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;
            if (board == null)
                return NotFound();

            var booking = new Booking
            {
                BoardId = boardId,
                DateFrom = dateFrom,
                DateTo = dateTo,
                Board = board,
                IsConfirmed = false, // By default, not confirmed
                UserId = userId
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Display the cart (list of bookings)
        public async Task<IActionResult> Cart()
        {
            var user = await _userManager.GetUserAsync(User);
            var id = user.Id;

            var userBookings = await _bookingRepository.GetBookingsByUserId(id);

            return View(userBookings);
        }
        public async Task<IActionResult> AdminCart()
        {
            var bookings = await _bookingRepository.GetAllBookings();

            return View(bookings);
        }


        // Optional: To remove a booking from the cart
        public async Task<IActionResult> RemoveBooking(int bookingId)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking == null)
                return NotFound();

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart");
        }
    }
}

