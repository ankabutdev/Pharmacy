using System.Collections.Generic;
namespace Pharmacy.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public required List<Medicine> Medicines { get; set; }
}
