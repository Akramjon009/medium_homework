using MediatR;
using Medium.Domain.Entities;

namespace Medium.Application.UseCases.MediumUser.Queries
{
    public class GetByIdUserCommandQuery : IRequest<User>
    {
        public Guid Id { get; set; }
    }
}
