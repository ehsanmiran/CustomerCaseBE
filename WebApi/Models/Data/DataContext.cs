using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<CaseEntity> Cases { get; set; }
    }
}