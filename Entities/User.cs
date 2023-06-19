using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pharmacy.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public DateTime CardExpiry { get; set; }
        public string CVV { get; set; } = string.Empty;
    }
}
