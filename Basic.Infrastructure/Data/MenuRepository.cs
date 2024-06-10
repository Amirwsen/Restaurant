using Basic.Core.Entities;
using Basic.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Basic.Infrastructure.Data;

public class MenuRepository : IRestaurantRepository
{
    private BasicDbContext _context;
    private IRestaurantRepository _restaurantRepositoryImplementation;

    public MenuRepository(BasicDbContext ctx)
    {
        _context = ctx;
    }
    public DbSet<RMenu> Menus { get; }
    public Task<List<RMenu>> GetAllMenus()
    {
        return _restaurantRepositoryImplementation.GetAllMenus();
    }

    public Task<RMenu> AddToMenu(RMenu rMenu)
    {
        return _restaurantRepositoryImplementation.AddToMenu(rMenu);
    }

    public Task<RMenu> ChangeMenu(RMenu rMenu)
    {
        return _restaurantRepositoryImplementation.ChangeMenu(rMenu);
    }

    public Task DeleteFromMenu(long id)
    {
        return _restaurantRepositoryImplementation.DeleteFromMenu(id);
    }
}