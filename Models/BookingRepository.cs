using Microsoft.EntityFrameworkCore;

namespace SurfsUp.Models
{
    public interface IBookingRepository
    {
        //Task<IEnumerable<Booking>> GetBookingsByUserId(string userId);
        Task AddBooking(Booking booking);
        Task<IEnumerable<Booking>> GetAllBookings();
    }

    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _context;

        public BookingRepository(AppDbContext context)
        {
            _context = context;
        }

        //public async Task<IEnumerable<Booking>> GetBookingsByUserId(string userId)
        //{
        //    return await _context.Bookings
        //        .Include(b => b.Board)
        //        .Where(b => b.UserId == userId)
        //        .ToListAsync();
        //}

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            return await _context.Bookings.Include(b => b.Board).ToListAsync();
        }

        public async Task AddBooking(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }
    }
}
