using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VelaFact.Responses
{
    public class ProductResponse
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Units { get; set; }
        public string Category { get; set; }

        public ProductResponse()
        {

        }

        public ProductResponse(long id, string description, double price, int units, string category)
        {
            Id = id;
            Description = description;
            Price = price;
            Units = units;
            Category = category;
        }
    }
}
