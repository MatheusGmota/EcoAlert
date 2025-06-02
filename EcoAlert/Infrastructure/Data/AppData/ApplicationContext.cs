using Microsoft.EntityFrameworkCore;

namespace EcoAlert.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}
