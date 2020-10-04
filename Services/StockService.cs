using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VelaFact.Responses;

namespace VelaFact.Services
{
    public class StockService
    {
        public List<ProductResponse> getProductsFromService() {

            var response = new List<ProductResponse>();

            response.Add(new ProductResponse(0, "tomate", 500, 8));
            response.Add(new ProductResponse(0, "cebolla", 600, 10));
            response.Add(new ProductResponse(0, "pepino", 1000, 11));
            response.Add(new ProductResponse(0, "aguacate", 3500, 32));

            return response;
        }
    }
}
