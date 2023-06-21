using System;

namespace Pharmacy.Entities;

public class AdminLog
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public required Order Order { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime LogDate { get; set; }
}