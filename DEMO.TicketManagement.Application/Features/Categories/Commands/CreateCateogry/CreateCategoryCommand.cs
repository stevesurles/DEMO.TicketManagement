using MediatR;

namespace DEMO.TicketManagement.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommand: IRequest<CreateCategoryCommandResponse>
    {
        public string Name { get; set; } = string.Empty;
    }
}
