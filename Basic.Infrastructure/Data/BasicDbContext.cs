using Basic.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Basic.Infrastructure.Data;

public class BasicDbContext : DbContext
{
    public DbSet<RMenu> Menus { get; set; }
    
    public BasicDbContext(DbContextOptions<BasicDbContext> options)
        : base(options)
    { }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RMenu>()
            .HasKey(b => b.Id);
        modelBuilder.Entity<RMenu>()
            .Property(b => b.Id)
            .IsRequired();
    }
}