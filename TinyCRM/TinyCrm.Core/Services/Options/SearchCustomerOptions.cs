using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCrm.Core.Services.Options
{
    public class SearchCustomerOptions
    {
        public string FirstName { get; set; }
        public string VatNumber { get; set; }
        public int? CustomerId { get; set; }
        public DateTimeOffset? CreateFrom { get; set; }


    }
}
