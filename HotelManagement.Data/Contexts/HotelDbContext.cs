using Microsoft.EntityFrameworkCore;
using HotelManagement.ViewModels.ViewModels;

namespace HotelManagement.Data.Contexts
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<ResponseDto> ResponseDto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResponseDto>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
