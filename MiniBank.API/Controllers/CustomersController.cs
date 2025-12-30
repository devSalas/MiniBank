using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiniBank.Application.Customers.Commands.CreateCustomer;

namespace MiniBank.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {

        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateCustomerCommand commnad)
        {
            return await _mediator.Send(commnad);
        }
    }
}
