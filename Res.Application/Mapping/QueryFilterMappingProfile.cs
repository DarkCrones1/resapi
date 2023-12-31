using AutoMapper;

using Res.Common.QueryFilters;
using Res.Domain.Dto.QueryFilters;
using Res.Domain.Entities;

namespace Res.Application.Mapping;

public class QueryFilterMappingProfile : Profile
{
    public QueryFilterMappingProfile()
    {
        CreateMap<BoxCashQueryFilter, BoxCash>();
        
        CreateMap<BranchStoreQueryFilter, BranchStore>();

        CreateMap<BaseCatalogQueryFilter, Category>();

        CreateMap<CategoryQueryFilter, Category>();

        CreateMap<CartQueryFilter, Cart>();

        CreateMap<BaseCatalogQueryFilter, Rol>();

        CreateMap<BaseCatalogQueryFilter, Job>();

        CreateMap<CustomerQueryFilter, Customer>();

        CreateMap<DrinkQueryFilter, Drink>();

        CreateMap<FoodQueryFilter, Food>();

        CreateMap<EmployeeQueryFilter, Employee>();

        CreateMap<MenuQueryFilter, Menu>();

        CreateMap<OrderQueryFilter, Order>();

        CreateMap<ReservationQueryFilter, Reservation>();

        CreateMap<TicketQueryFilter, Ticket>();

        CreateMap<PaymentQueryFilter, Payment>();
    }
}