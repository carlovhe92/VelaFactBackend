using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VelaFact.Database;
using VelaFact.Models;

namespace VelaFact.Repositories
{
    public class StockRepository
    {        
        readonly StockContext _ctx;

        public StockRepository(StockContext ctx)
        {
            _ctx = ctx;
        }

        public List<Product> GetProducts()
        {
            return _ctx.Products.ToList();
        }

        public void AddUnits(int productId, int additionalUnits)
        {
            foreach (var item in _ctx.Products.ToList())
            {
                if (item.Id == productId)
                {
                    item.Units = item.Units + additionalUnits;
                }
            }
        }
    }
}
