using HotelAPI.BO;
using HotelAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace HotelAPI.DA
{
    public partial class AppDBContext : DbContext
    {
      
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }


        public virtual DbSet<HotelBooking> HotelBookings { get; set; } = null!;

        public virtual DbSet<HotelMaster> HotelMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<HotelBooking>(entity =>
            {
                entity.Property(e => e.BookingId).ValueGeneratedOnAdd();
            });

            

            modelBuilder.Entity<HotelMaster>(entity =>
            {
                entity.Property(e => e.HotelAddedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.HotelAddedDatetime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HotelId).ValueGeneratedOnAdd();

                entity.Property(e => e.HotelRooms).HasDefaultValueSql("((1))");

                entity.Property(e => e.HotelStatus).HasDefaultValueSql("((1))");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}