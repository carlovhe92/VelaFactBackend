using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VelaFact.Responses
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Units { get; set; }

        public ProductResponse()
        {

        }

        public ProductResponse(int id, string description, double price, int units)
        {
            Id = id;
            Description = description;
            Price = price;
            Units = units;
        }
    }
}
