using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace GotMilkWeed
{
    public class MilkweedDbContext : DbContext
    {
        public string DbPath { get; }
        public MilkweedDbContext()

        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Milkweed.db");
        }


        public DbSet<MilkweedVariety> milkweedVarieties { get; set; }

        public DbSet<MilkweedVariety> GetMilkweedVarieties()
        {
            return milkweedVarieties;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var varieties = new List<MilkweedVariety>()
            {

            new MilkweedVariety { Id = 1, Name = "Common Milkweed", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 2, Name = "Butterfly Weed", Region = "North America", IsToxicToMonarchs = false },
            new MilkweedVariety { Id = 3, Name = "Swamp Milkweed", Region = "North America", IsToxicToMonarchs = false },
            new MilkweedVariety { Id = 4, Name = "Showy Butterfly", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 5, Name = "Whorled Milkweed", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 6, Name = "Green Milkweed", Region = "North America", IsToxicToMonarchs = false },
            new MilkweedVariety { Id = 7, Name = "Antelope Horns", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 8, Name = "Purple Milkweed", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 9, Name = "Sand Milkweed", Region = "North American", IsToxicToMonarchs = false },
            new MilkweedVariety { Id = 10, Name = "Red Milkweed", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 11, Name = "Poke Milkweed", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 12, Name = "Texas Milkweed", Region = "North America", IsToxicToMonarchs = false },
            new MilkweedVariety { Id = 13, Name = "Sullivants Milkweed", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 14, Name = "Horsetail Milkweed", Region = "North America", IsToxicToMonarchs = true },
            new MilkweedVariety { Id = 15, Name = "Clasping Milkweed", Region = "North America", IsToxicToMonarchs = true },
            ///Add more Ids
        };
            foreach (var variety in varieties)
            {
                modelBuilder.Entity<MilkweedVariety>().HasData(variety);

            }

        }
        public void SetMilkweedVarieties(DbSet<MilkweedVariety> value)
        {
            milkweedVarieties = value;
        }
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
