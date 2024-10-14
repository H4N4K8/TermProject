using Microsoft.EntityFrameworkCore;
using Chapter3Project.Models;

namespace Chapter3Project.Models
{
    public class SetContext : DbContext
    {
        public SetContext(DbContextOptions<SetContext> options) : base(options) { }

        public DbSet<Set> sets { get; set; } = null!;
        public DbSet<ClothingPoses> CPoses { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Set>().HasData(
                 new Set
                 {
                     SetId = "M",
                     SetName = "Moving"
                 },
                 new Set
                 {
                     SetId = "D",
                     SetName = "Dressing"
                 },
                new Set
                {
                    SetId = "B",
                    SetName = "Bath"
                },
                new Set
                {
                    SetId = "Y",
                    SetName = "Yoga"
                },
                new Set
                {
                    SetId = "E",
                    SetName = "Exercise"
                },
                new Set
                {
                    SetId = "C",
                    SetName = "Cheer"
                },
                new Set
                {
                    SetId = "W",
                    SetName = "Work"
                },
                new Set
                {
                    SetId = "L",
                    SetName = "Living"
                },
                new ClothingPoses
                {
                    Id = 2,
                    SetId = "D",
                    SetName = "Dressing",
                    SmiskiType = "Pants Smiski"
                },
                new ClothingPoses
                {
                    Id = 1,
                    SetId = "D",
                    SetName = "Dressing",
                    SmiskiType = "Sweater Smiski"
                }
             );
        }
        public DbSet<Chapter3Project.Models.ClothingPoses> ClothingPoses { get; set; } = default!;
    }
}
