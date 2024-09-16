using Microsoft.AspNetCore.Mvc;
using SurfsUp.Models;

namespace SurfsUp.Controllers
{
    public class BoardsController : Controller
    {
        private readonly IBoardRepository _boardRepository;

        public BoardsController(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public async Task<IActionResult> Index()
        {
            var boards = await _boardRepository.GetAllBoards();
            
            return View(boards);
        }

        //public async Task<IActionResult> BoardModal(int id)
        //{
        //    var chosenBoard = await _boardRepository.GetBoardById(id);

        //    return View(chosenBoard);
        //}

        
    }
}
