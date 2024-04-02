using MediatorApp.Domain.Commands.Requests;
using MediatorApp.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatorApp.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create([FromServices] IMediator mediator, [FromBody] CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}
