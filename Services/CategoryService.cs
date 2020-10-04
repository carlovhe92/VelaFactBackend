using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VelaFact.Responses;

namespace VelaFact.Services
{
    public class CategoryService
    {
        public List<CategoryResponse> getCategoriesFromService()
        {

            var category = new List<CategoryResponse>();

            category.Add(new CategoryResponse(0, "Verduras", 0));
            category.Add(new CategoryResponse(1, "Granos", 0));
            category.Add(new CategoryResponse(2, "Frutas", 0));
            category.Add(new CategoryResponse(3, "Tuberculos", 0));

            return category;
        }
    }
}
