using System;

namespace Magenic
{
    public class Transaction
    {
        public string Vendor { get; set; }
        public string Amount { get; set; }
        public DateTime Date { get; set; }
        public string VendorUrl { get; set; }
    }
}
