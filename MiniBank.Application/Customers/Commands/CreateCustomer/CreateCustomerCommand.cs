using MediatR;
using MiniBank.Application.Common.Interfaces;
using MiniBank.Domain.Entities;


namespace MiniBank.Application.Customers.Commands.CreateCustomer
{
    public record CreateCustomerCommand(string FirstName, string LastName, string Email): IRequest<Guid>;
   
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateCustomerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async  Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = new Customer
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };
            _context.Customers.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }

    }
}
