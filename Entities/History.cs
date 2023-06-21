using System;
namespace Pharmacy.Entities;
public class History
{
    public int Id { get; set; }
    public required User User { get; set; }
    public int MedicineId { get; set; }
    public required Medicine Medicine { get; set; }
    public int Quantity { get; set; }
    public float TotalAmount { get; set; }
    public DateTime PurchaseDate { get; set; }
}
