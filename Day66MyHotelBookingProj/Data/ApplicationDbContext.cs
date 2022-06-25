using Day66MyHotelBookingProj.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Day66MyHotelBookingProj.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }

}
