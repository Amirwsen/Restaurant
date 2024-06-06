using Basic.Application.DTOs;
using Basic.Core.Interfaces;

namespace Basic.Application.UseCases;

public class ShowUserData
{
    private readonly IRestaurantRepository _restaurantRepository;

    public ShowUserData(IRestaurantRepository restaurantRepository)
    {
        _restaurantRepository = restaurantRepository;
    }

    public async Task<List<ShowData>> GetAllMenus()
    {
        return (await _restaurantRepository.GetAllMenus()).Select(x => new ShowData
        {
            Id = x.Id,
            Description = x.Description,
            FoodName = x.FoodName,
            Category = x.Category,
            Price = x.Price
        }).ToList();
    }
}