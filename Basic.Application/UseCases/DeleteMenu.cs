using Basic.Core.Interfaces;

namespace Basic.Application.UseCases;

public class DeleteMenu
{
    private readonly IRestaurantRepository _restaurantRepository;

    public DeleteMenu(IRestaurantRepository restaurantRepository)
    {
        _restaurantRepository = restaurantRepository;
    }

    public async Task DeleteRecord(long id)
    {
        await _restaurantRepository.DeleteFromMenu(id);
    }
}