using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestBackend.MODEL.Entities;

namespace TestBackend.CONTEXT.Context
{
    public class TestBackendContext : IdentityDbContext<User>
    {
        public TestBackendContext(DbContextOptions options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

      
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelClass> HotelClasses { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        //public DbSet<HotelService> HotelServices { get; set; }
        public DbSet<HotelStatus> HotelStatuses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        //public DbSet<RoomBooking> RoomBookings { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        //public DbSet<RoomStatus> RoomStatuses { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Service> Services { get; set; }


    }
}
