using System.Collections.Frozen;
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

    public async Task<RMenu> AddToMenu(RMenu rMenu)
    {
        await _database.Menus.AddAsync(rMenu);
        await _database.SaveChangesAsync();
        return rMenu;
    }

    public async Task<RMenu> ChangeMenu(RMenu rMenu)
    {
        var changeRecord = await _database.Menus.Where(x => x.Id == rMenu.Id).FirstAsync();
        changeRecord.FoodName = rMenu.FoodName;
        changeRecord.Description = rMenu.Description;
        changeRecord.Category = rMenu.Category;
        changeRecord.Price = rMenu.Price;
        changeRecord.UpdatedAt = DateTime.Now;
        await _database.SaveChangesAsync();
        return rMenu;
    }

    public async Task DeleteFromMenu(long id)
    {
        await _database.Menus.Where(x => x.Id == id).ExecuteDeleteAsync();
    }
}