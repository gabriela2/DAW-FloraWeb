using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecificication : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecificication(ProductSpecParams productParams) 
            : base(x => 
                (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
                (!productParams.CategoryId.HasValue || x.ProductCategoryId == productParams.CategoryId) &&
                (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
            )
        {
        }
    }
}