using Microsoft.EntityFrameworkCore;

namespace Chapter3Project.Models
{
    public class SetContext : DbContext
    {
        public SetContext(DbContextOptions<SetContext> options) : base(options) { }

        public DbSet<Set> sets { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Set>().HasData(
                 new Set
                 {
                     Id = "M",
                     SetName = "Moving",
                     SmiskiType ="Boxes Smiski"
                 },
                 new Set
                 {
                     Id = "D",
                     SetName = "Dressing",
                     SmiskiType = "Sweater Smiski"
                 },
                new Set
                {
                    Id = "B",
                    SetName = "Bath",
                    SmiskiType = "Shower Smiski"
                },
                new Set
                {
                    Id = "Y",
                    SetName = "Yoga",
                    SmiskiType = "Grounded Smiski"
                },
                new Set
                {
                    Id = "E",
                    SetName = "Exercise",
                    SmiskiType = "Sit Ups Smiski"
                },
                new Set
                {
                    Id = "C",
                    SetName = "Cheer",
                    SmiskiType = "Pom Pom Smiski"
                },
                new Set
                {
                    Id = "W",
                    SetName = "Work",
                    SmiskiType = "Laptop Smiski"
                },
                new Set
                {
                    Id = "L",
                    SetName = "Living",
                    SmiskiType = "Flute Smiski"
                }
             );
        }
    }
}
