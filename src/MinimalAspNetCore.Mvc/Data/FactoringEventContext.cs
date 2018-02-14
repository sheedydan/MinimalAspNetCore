using Microsoft.EntityFrameworkCore;
using MinimalAspNetCore.Mvc.Models;

namespace MinimalAspNetCore.Mvc.Data
{
    public class FactoringEventContext : DbContext
    {
        public FactoringEventContext(DbContextOptions<FactoringEventContext> options) : base(options)
        {
        }

        public DbSet<FactoringEventNotice> FactoringEventNotices { get; set; }
    }
}
