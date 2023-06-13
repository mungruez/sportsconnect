using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SportsconnectAPI.Models;


namespace SportsconnectAPI.Data
{

    public class SportsConnectDBContext : DbContext
    {

            
        public SportsConnectDBContext(DbContextOptions options) : base(options) 
        {

        }
        


        public DbSet<Player> Players { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasKey(c => c.Id);
            modelBuilder.Entity<Event>().HasKey(c => c.Id);
            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    name = "William",
                    age = 17,
                    sport = "Soccer",
                    phone = "8687375691",
                    address = "Shakespeare Avenue",
                    lastActive = DateTime.Now,
                    attending = "No Events",
                    pCode = 12972
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    name = "Zaak",
                    age = 19,
                    sport = "Soccer",
                    phone = "18687964097",
                    address = "Woodbrook",
                    lastActive = DateTime.Now,
                    attending = "No Events",
                    pCode = 12976
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    name = "Cody",
                    age = 34,
                    sport = "Soccer",
                    phone = "186879874097",
                    address = "PortofSpain",
                    lastActive = DateTime.Now,
                    attending = "15773",
                    pCode = 12970
                }, 
                new Player
                {
                    Id = Guid.NewGuid(),
                    name = "Micheal",
                    age = 34,
                    sport = "All",
                    phone = "1868732274097",
                    address = "Down Town",
                    lastActive = DateTime.Now,
                    attending = "15775, 1573",
                    pCode = 12973
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    name = "Gervais",
                    age = 38,
                    sport = "Soccer",
                    phone = "1868732274097",
                    address = "San Juan",
                    lastActive = DateTime.Now,
                    attending = "15774, 1575, 15773",
                    pCode = 12971
                }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event { Id = Guid.NewGuid(), title = "Soccer Meet",duration= 2,sport="Soccer",owner="12970",location="Port of Spain",startDate=DateTime.Now,playersAttending="12971",pCode=15774},
                new Event { Id = Guid.NewGuid(), title = "Soccer Match",duration = 2,sport = "Soccer",owner = "12973",location = "Port of Spain",startDate = DateTime.Now, playersAttending="12971",pCode=15775 },
                new Event { Id = Guid.NewGuid(), title = "SoccerMeet Game",duration = 2, sport = "Soccer",owner = "12971",location = "Port of Spain",startDate = DateTime.Now, playersAttending="12970",pCode=15773 }
                
            );
        }
    }
}
