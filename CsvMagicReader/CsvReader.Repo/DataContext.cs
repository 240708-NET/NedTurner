
using Microsoft.EntityFrameworkCore;
using CsvReader.Models;

namespace CsvReader.Repo
{
    class DataContext : DbContext
    {
        public DbSet<Tip> Tips => Set<Tip>();
        public DbSet<Honey> HoneyProduction => Set<Honey>();


        
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) base(options){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = File.ReadAllText(@"../CsvReader.Repo/connectionstring");
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}