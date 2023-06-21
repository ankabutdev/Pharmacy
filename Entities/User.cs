using System;
namespace Pharmacy.Entities;

public class User
{
    public string CardNumber { get; set; } = string.Empty;
    public DateTime CardExpiry { get; set; }
    public string CVV { get; set; } = string.Empty;
}
