using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VelaFact.Models;

namespace VelaFact.Repositories
{
    public class StockRepository
    {
        List<Product> Products = new List<Product>() {
            new Product(0, "tomate", 500, 8, 2),
            new Product(1, "cebolla", 600, 10, 1),
            new Product(2, "pepino", 1000, 11, 3),
            new Product(3, "aguacate", 3500, 32, 2),
        };

        public List<Product> GetProducts()
        {
            return Products;
        }

        public void AddUnits(int productId, int additionalUnits)
        {
            foreach (var item in Products)
            {
                if (item.Id == productId)
                {
                    item.Units = item.Units + additionalUnits;
                }
            }
        }
    }
}
