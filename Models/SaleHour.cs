using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SalesProjection.Models
{
    public class SaleHour
    {
        //[JsonPropertyName("hour")]
        public int Name { get; set; }

        //[JsonPropertyName("amount")]
        public decimal Value { get; set; }
    }
}
