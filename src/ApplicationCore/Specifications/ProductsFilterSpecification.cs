using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications
{
    public class ProductsFilterSpecification : Specification<Product>
    {
        public ProductsFilterSpecification(int? categoryId, int? brandId)  // butun urunler
        {
            if (categoryId.HasValue)
                Query.Where(x => x.CategoryId == categoryId);

            if (brandId.HasValue)
                Query.Where(x => x.BrandId == brandId);
        }

        public ProductsFilterSpecification(int? categoryId, int? brandId, int page, int itemsPerPage) : this(categoryId, brandId)  // sayfalandırma ıcın
        {
            Query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);  // orn: 3. sayfada 8 atla sıradakı 4'u al
        }
    }
}
