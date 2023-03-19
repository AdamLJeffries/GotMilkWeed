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
