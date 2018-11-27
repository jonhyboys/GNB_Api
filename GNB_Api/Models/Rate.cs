using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GNB_Api.Models
{
    public class Rate
    {
        public string from { get; set; }
        public string to { get; set; }
        public decimal rate { get; set; }
    }
}