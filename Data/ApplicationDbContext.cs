using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StayHealthy.Models;

namespace StayHealthy.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<StayHealthy.Models.Article>? Article { get; set; }
    public DbSet<StayHealthy.Models.Consult>? Consult { get; set; }
}
