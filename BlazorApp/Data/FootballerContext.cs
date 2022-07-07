using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class FootballerContext : DbContext
    {
        public DbSet<Footballer> Footballers { get; set; }

        public FootballerContext(DbContextOptions<FootballerContext> options) : base(options)
        {

        }
    }
}
