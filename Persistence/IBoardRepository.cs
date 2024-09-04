namespace SurfsUp.Persistence
{
    public interface IBoardRepository : IDisposable
    {
        void CreateBoard();
        void GetBoard();
        void UpdateBoard();
        void DeleteBoard();

    }
}
