using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurfsUp.Models;

namespace SurfsUp.Controllers
{
    public class BoardsController : Controller
    {
        private readonly IBoardRepository _boardRepository;
        private readonly AppDbContext _context;

        public BoardsController(IBoardRepository boardRepository, AppDbContext context)
        {
            _boardRepository = boardRepository;
            _context = context;
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
            if (board == null)
                return NotFound();

            var booking = new Booking
            {
                BoardId = boardId,
                DateFrom = dateFrom,
                DateTo = dateTo,
                Board = board,
                IsConfirmed = false // By default, not confirmed
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Display the cart (list of bookings)
        public async Task<IActionResult> Cart()
        {
            var bookings = await _context.Bookings.Include(b => b.Board).ToListAsync();
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

