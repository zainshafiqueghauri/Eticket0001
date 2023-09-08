using eticket.Models;
using Microsoft.EntityFrameworkCore;


//qustion no : what is HasOne method in entity framework? look it on 
namespace eticket.Data
{
    public class AddDbContextcs:DbContext // instal pakage microsoft entity frame work core by mouese over on this 
    {
        public AddDbContextcs(DbContextOptions<AddDbContextcs> Options ):base(Options)//Constructor
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)// after OnModelCreating auto generte by tabe button
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            }); 
            modelBuilder
                .Entity<Actor_Movie>()
                .HasOne(m=>m.movie)
                .WithMany(am=> am.Actor_Movie)
                .HasForeignKey(m=> m.MovieId);
            modelBuilder
                .Entity<Actor_Movie>()
                .HasOne(m => m.Actor)
                .WithMany(am => am.Actor_Movie)
                .HasForeignKey(m => m.ActorId);
           
            base.OnModelCreating(modelBuilder);
        }

        public  DbSet<Actor> actors { get; set; }//representing tables
        public DbSet<Movie> movie { get; set; }
        public DbSet<Actor_Movie> actor_movie { get; set; }
        public DbSet<Cinemascs> Cinema { get; set; }
        public DbSet<Producer> producer { get; set; }

    }
}
