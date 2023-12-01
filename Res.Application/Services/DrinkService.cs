using Res.Common.Entities;
using Res.Domain.Dto.QueryFilters;
using Res.Domain.Entities;
using Res.Domain.Interfaces;
using Res.Domain.Interfaces.Services;

namespace Res.Application.Services;

public class DrinkService : CatalogBaseService<Drink>, IDrinkService
{
    public DrinkService(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    public async Task<PagedList<Drink>> GetPaged(DrinkQueryFilter filter)
    {
        var result = await _unitOfWork.DrinkRepository.GetPaged(filter);
        var pagedItems = PagedList<Drink>.Create(result, filter.PageNumber, filter.PageSize);
        return pagedItems;
    }
}