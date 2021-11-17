using System;

namespace CQRSDemo.Models
{
    public class Invoice
    {

        public long InvoiceNo { get; set; }
        public DateTime DOI { get; set; }

        public long Amount { get; set; }

    }
}
