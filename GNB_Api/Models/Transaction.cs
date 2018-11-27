using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GNB_Api.Models
{
    public class Transaction
    {
        public string sku { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
    }
}