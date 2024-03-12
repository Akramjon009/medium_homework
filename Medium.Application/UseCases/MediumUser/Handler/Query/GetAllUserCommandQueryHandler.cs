using MediatR;
using Medium.Application.Absatractions;
using Medium.Application.UseCases.MediumUser.Queries;
using Medium.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medium.Application.UseCases.MediumUser.Handler.Query
{
    public class GetAllUserCommandQueryHandler : IRequestHandler<GetAllUsersCommandQuery, List<User>>
    {

        private readonly IApplicationDbContext _applicationDbContext;
        public GetAllUserCommandQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<User>> Handle(GetAllUsersCommandQuery request, CancellationToken cancellationToken)
        {
            var users = await _applicationDbContext.Users.Where(x => x.IsDeleted != true).ToListAsync();
            return users;
        }
    }
}
