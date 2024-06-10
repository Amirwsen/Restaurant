using Basic.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Basic.Infrastructure.Data;

public class BasicDbContext : DbContext //DB configuration 
{
    
    public BasicDbContext(DbContextOptions<BasicDbContext> options)
        : base(options)
    { }
    public DbSet<RMenu> Menus { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) // set PrimeKey
    {
        modelBuilder.Entity<RMenu>()
            .HasKey(b => b.Id);
        modelBuilder.Entity<RMenu>()
            .Property(b => b.Id)
            .IsRequired();
        
        SeedData2.Seed2(modelBuilder);
    }
    
}
