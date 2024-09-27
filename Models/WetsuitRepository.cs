using Microsoft.EntityFrameworkCore;

namespace SurfsUp.Models
{
    public interface IWetsuitRepository
    {
        Task<IEnumerable<Wetsuit>> GetAllWetsuits();
        Task<Wetsuit> GetWetsuitById(int id);
        Task Add(Wetsuit wetsuit);
        Task Update(Wetsuit wetsuit);
        Task Delete(Wetsuit wetsuit);
    }

    public class WetsuitRepository : IWetsuitRepository
    {
        private readonly AppDbContext _context;
        public WetsuitRepository(AppDbContext context)
        {
            _context = context;
        }
        //Boards
        public async Task<IEnumerable<Wetsuit>> GetAllWetsuits()
        {
            return await _context.Wetsuits.ToListAsync();
        }

        public async Task<Wetsuit> GetWetsuitById(int id)
        {
            return await _context.Wetsuits.FindAsync(id);
        }

        public async Task Add(Wetsuit wetsuit)
        {
            await _context.Wetsuits.AddAsync(wetsuit);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Wetsuit wetsuit)
        {
            _context.Wetsuits.Update(wetsuit);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Wetsuit wetsuit)
        {
            _context.Remove(wetsuit);
            await _context.SaveChangesAsync();
        }

    }
}
