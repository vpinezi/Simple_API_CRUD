using Microsoft.EntityFrameworkCore;
using Simple_API_CRUD.Models;

namespace Simple_API_CRUD.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<AccountDetails> Accounts { get; set; }
    }
}
