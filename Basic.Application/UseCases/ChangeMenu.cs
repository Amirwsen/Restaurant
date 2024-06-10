using Basic.Application.DTOs;
using Basic.Core.Entities;
using Basic.Core.Interfaces;

namespace Basic.Application.UseCases;

public class ChangeMenu
{
    private readonly IRestaurantRepository _restaurantRepository;

    public ChangeMenu(IRestaurantRepository restaurantRepository)
    {
        _restaurantRepository = restaurantRepository;
    }

    public async Task<ShowData> UpdateMenu(ShowData showData , CancellationToken cancellationToken)
    {
        var response = await _restaurantRepository.ChangeMenu(new RMenu
        {
            Id = showData.Id,
            FoodName = showData.FoodName,
            Category = showData.Category,
            Price = showData.Price,
            Description = showData.Description,
        });
        return new ShowData
        {
            Id = response.Id,
            Description = response.Description,
            FoodName = response.FoodName,
            Category = response.Category,
            Price = response.Price
        };
    }
}