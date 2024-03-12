using MediatR;
using Medium.Application.Absatractions;
using Medium.Application.UseCases.MediumUser.Queries;
using Medium.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medium.Application.UseCases.MediumUser.Handler.Handler
{
    public class GetByIdUserCommandHandler : IRequestHandler<GetByIdUserCommandQuery, User>
    {
        private readonly IApplicationDbContext _dbContext;
        public GetByIdUserCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Handle(GetByIdUserCommandQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted != true);
            return user;
        }
    }
}
