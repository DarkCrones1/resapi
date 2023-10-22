using Res.Common.Interfaces.Repositories;
using Res.Domain.Dto.QueryFilters;
using Res.Domain.Entities;

namespace Res.Domain.Interfaces.Repositories;

public interface ICategoryRepository : ICatalogBaseRepository<Category>, IQueryFilterPagedRepository<Category, CategoryQueryFilter>
{
}