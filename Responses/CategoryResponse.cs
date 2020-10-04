using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VelaFact.Responses
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Units { get; set; }

        public CategoryResponse()
        {

        }

        public CategoryResponse(int id, string description,  int units)
        {
            Id = id;
            Description = description;
            Units = units;
        }

    }
}
