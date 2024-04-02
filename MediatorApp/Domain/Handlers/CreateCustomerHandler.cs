using MediatR;
using MediatorApp.Domain.Commands.Requests;
using MediatorApp.Domain.Commands.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorApp.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
