using Microsoft.EntityFrameworkCore;
using CsvReader.Models;

namespace CsvReader.Repo
{
    class DataContext : DbContext
    {
        public DbSet<Tip> Tips

    }
}