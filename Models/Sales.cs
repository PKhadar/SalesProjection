using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SalesProjection.Models
{
    public class Sales
    {
        //[JsonPropertyName("saleDate")]
        public string Name { get; set; }

        //[JsonPropertyName("saleHour")]
        public List<SaleHour> Series { get; set; }

    }
}
