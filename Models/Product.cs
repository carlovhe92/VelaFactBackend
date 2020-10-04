using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VelaFact.Models
{
    /* los modelos son entidades para guardar informacion */
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Units { get; set; }
        public int IdCategory { get; set; }

        public Product()
        {

        }

        public Product(int id, string description, double price, int units, int idCategory)
        {
            Id = id;
            Description = description;
            Price = price;
            Units = units;
            IdCategory = idCategory;
        }
    }
}
