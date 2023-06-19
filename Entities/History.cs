using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Entities
{
    public class History
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MedicineId { get; set; }
        public required Medicine Medicine { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
