using MediatR;
using MediatorApp.Domain.Commands.Responses;

namespace MediatorApp.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
