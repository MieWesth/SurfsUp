using Microsoft.AspNetCore.Mvc;
using SurfsUp.Models;

namespace SurfsUp.Controllers
{
    public class BookingsController : Controller
    {
        private readonly IBoardRepository _boardRepository;

        public BookingsController(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public async Task<IActionResult> Index(int id)
        {
            var chosenBoard = await _boardRepository.GetBoardById(id);
            chosenBoard.IsBooked = true;
            _boardRepository.AddBooking(chosenBoard);

            return View(chosenBoard);
        }
    }
}