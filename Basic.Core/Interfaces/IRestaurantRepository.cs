using Basic.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Basic.Core.Interfaces;

public class IRestaurantRepository
{
    IQueryable<RMenu> Menus { get; }
}