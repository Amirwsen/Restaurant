using System.ComponentModel.DataAnnotations.Schema;

namespace Basic.Core.Entities;

public class RMenu // make a structure for creating DB
{
    public long Id { get; set; }
    public string FoodName { get; set; } = string.Empty;
    [Column (TypeName = "decimal(9, 2)")]
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string Category { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}