using System.ComponentModel.DataAnnotations.Schema;

namespace Basic.Application.DTOs;

public class ShowData
{
    public long Id { get; set; }
    public string FoodName { get; set; } = string.Empty;
    [Column(TypeName = "decimal(9, 2)")] public decimal Price { get; set; }
    public string? Description { get; set; }
    public string Category { get; set; } = string.Empty;
}