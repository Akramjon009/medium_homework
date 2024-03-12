using MediatR;
using Medium.Domain.Entities;

namespace Medium.Application.UseCases.MediumUser.Queries
{
    public class GetAllUsersCommandQuery : IRequest<List<User>>
    {

    }
}
