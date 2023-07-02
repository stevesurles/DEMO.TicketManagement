using AutoMapper;
using DEMO.TicketManagement.Application.Features.Categories.Commands.CreateCateogry;
using DEMO.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using DEMO.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using DEMO.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using DEMO.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using DEMO.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
//using DEMO.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using DEMO.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using DEMO.TicketManagement.Application.Features.Orders.GetOrdersForMonth;
using DEMO.TicketManagement.Domain.Entities;

namespace DEMO.TicketManagement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            //CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
