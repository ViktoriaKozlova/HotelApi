using Microsoft.EntityFrameworkCore;
using HotelApi.Models;

namespace HotelApi.Context
{
    public class RoomContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public RoomContext(DbContextOptions<RoomContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
