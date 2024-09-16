namespace SurfsUp.Models
{
    public interface IBoardRepository
    {
        Task<IEnumerable<Board>> GetAllBoards();
        Task<Board> GetBoardById(int id);
        Task Add(Board board);
        Task Update(Board board);
        Task Delete(Board board);


        //Task<IEnumerable<Board>> GetAllBookedBoards();
        //Task<Board> GetBookedBoardById(int id);
        //Task AddBooking(Board bookedBoard);
        //Task UpdateBooking(Board bookedBoard);
        //Task DeleteBooking(Board bookedBoard);
    }
}
