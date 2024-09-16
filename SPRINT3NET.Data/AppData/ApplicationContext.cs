using SPRINT3NET.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SPRINT3NET.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        { 
        }
        public DbSet<SitesEntity> Sites { get; set; }
    }
}
