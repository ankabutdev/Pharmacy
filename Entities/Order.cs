using System;
using System.Collections.Generic;

namespace Pharmacy.Entities;

public class Order
{
    public int Id { get; set; }
    public required User User { get; set; }
    public int MedicineId { get; set; }
    public required Medicine Medicine { get; set; }
    public int Quantity { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; } = string.Empty;
    public required List<AdminLog> AdminLogs { get; set; }
}
