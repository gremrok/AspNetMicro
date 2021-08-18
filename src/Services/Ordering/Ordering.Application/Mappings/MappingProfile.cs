using AutoMapper;
using Ordering.Application.Features.Orders.Commands;
using Ordering.Application.Features.Orders.Queries.GetOrdersList;
using Ordering.Domain;

namespace Ordering.Application.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
