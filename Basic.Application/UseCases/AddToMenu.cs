using Basic.Application.DTOs;
using Basic.Core.Entities;
using Basic.Core.Interfaces;

namespace Basic.Application.UseCases;
//add Data to data base by user

public class AddToMenu
{
    private readonly IRestaurantRepository _restaurantRepository;

    public AddToMenu(IRestaurantRepository restaurantRepository)
    {
        _restaurantRepository = restaurantRepository;
    }

    public async Task<ShowData> CreateNewMenuItem(ShowDataRequest showData)
    {
        var newRecord = await _restaurantRepository.AddToMenu(new RMenu
        {
            Price = showData.Price,
            Category = showData.Category,
            Description = showData.Description,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        });
        return new ShowData
        {
            Id = newRecord.Id,
            Category = newRecord.Category,
            Price = newRecord.Price,
            Description = newRecord.Description,
            FoodName = newRecord.FoodName
        };
    }
}