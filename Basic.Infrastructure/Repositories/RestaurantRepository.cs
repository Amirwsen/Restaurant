using Basic.Core.Entities;
using Basic.Core.Interfaces;
using Basic.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Basic.Infrastructure.Repositories;

public class RestaurantRepository : IRestaurantRepository //
{
    private readonly BasicDbContext _database;

    public RestaurantRepository(BasicDbContext database)
    {
        _database = database;
    }
    public async Task<List<RMenu>> GetAllMenus()
    {
        return await _database.Menus.ToListAsync();
    }
}