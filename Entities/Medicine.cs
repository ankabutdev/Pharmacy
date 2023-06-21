namespace Pharmacy.Entities;

public class Medicine
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Where_from { get; set; } = string.Empty;
    public float Price { get; set; }
    public int CategoryId { get; set; }
    public required Category Category { get; set; }
/*        public List<Order> Orders { get; set; }
    public List<Review> Reviews { get; set; }*/
}