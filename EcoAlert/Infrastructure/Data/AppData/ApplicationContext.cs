using EcoAlert.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcoAlert.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<LimiarEntity> Limiar { get; set; }
    }
}
