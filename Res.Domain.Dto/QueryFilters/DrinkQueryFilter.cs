using Res.Common.Interfaces.Entities;
using Res.Common.QueryFilters;

namespace Res.Domain.Dto.QueryFilters;

public class DrinkQueryFilter : BaseCatalogQueryFilter
{
    public decimal Price { get; set; }

    public decimal LowPriceRange { get; set; }

    public decimal HighPriceRange { get; set; }

    public int[]? CategoryId { get; set; }
}