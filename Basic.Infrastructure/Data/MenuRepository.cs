using Basic.Core.Entities;
using Basic.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Basic.Infrastructure.Data;

public class MenuRepository : IRestaurantRepository
{
    private BasicDbContext _context;

    public MenuRepository(BasicDbContext ctx)
    {
        _context = ctx;
    }
    public DbSet<RMenu> Menus { get; }
}