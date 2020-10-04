using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VelaFact.Repositories;
using VelaFact.Responses;

namespace VelaFact.Services
{
    public class StockService
    {
        readonly StockRepository _stockRepository;
        public StockService(StockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public List<ProductResponse> getProductsFromService()
        {

            var products = _stockRepository.GetProducts();

            var response = new List<ProductResponse>();

            foreach (var item in products)
            {
                response.Add(new ProductResponse(
                    item.Id, item.Description, item.Price, item.Units, "frutas")
                    );
            }

            return response;
        }

        public void AddUnitsToProduct(int productId, int units)
        {
            _stockRepository.AddUnits(productId, units);
        }
    }
}
