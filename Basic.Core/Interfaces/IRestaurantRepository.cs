using Basic.Core.Entities;

namespace Basic.Core.Interfaces;

public interface IRestaurantRepository // Making a list of our DB structure
{
    Task<List<RMenu>> GetAllMenus();

    Task<RMenu> AddToMenu(RMenu rMenu);

    Task<RMenu> ChangeMenu(RMenu rMenu);

    Task DeleteFromMenu(long id);
}