using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CQRSDemo.Models
{
    public class Customer
    {
        [Key]
        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public long MobileNo { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public ICollection<Invoice> InvoiceList { get; set; }

    }
}
