using Microsoft.EntityFrameworkCore;

namespace SurfsUp.Models
{
    public interface IBoardRepository
    {
        Task<IEnumerable<Board>> GetAllBoards();
        Task<Board> GetBoardById(int id);
        Task Add(Board board);
        Task Update(Board board);
        Task Delete(Board board);
    }

    public class BoardRepository : IBoardRepository
    {
        private readonly AppDbContext _context;
        public BoardRepository(AppDbContext context)
        {
            _context = context;
        }
        //Boards
        public async Task<IEnumerable<Board>> GetAllBoards()
        {
            return await _context.Boards.ToListAsync();
        }
        public async Task<Board> GetBoardById(int id)
        {
            return await _context.Boards.FindAsync(id);
        }

        public async Task Add(Board board)
        {
            await _context.Boards.AddAsync(board);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Board board)
        {
            _context.Boards.Update(board);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Board board)
        {
            _context.Remove(board);
            await _context.SaveChangesAsync();
        }

    }
}

