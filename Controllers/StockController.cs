using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VelaFact.Responses;
using VelaFact.Services;

namespace VelaFact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        readonly StockService _stockService;

        public StockController(StockService stockService)
        {
            _stockService = stockService;
        }


        [HttpGet]
        public List<ProductResponse> getProducts() {
            return _stockService.getProductsFromService();
        }
    }
}