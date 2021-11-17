using System.Collections.Generic;

namespace CQRSDemo.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public long MobileNo { get; set; }
        public string Email { get; set; }

        public ICollection<Invoice> colllection { get; set; }

    }
}
