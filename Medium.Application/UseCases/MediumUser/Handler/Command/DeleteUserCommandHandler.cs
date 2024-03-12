using MediatR;
using Medium.Application.Absatractions;
using Medium.Application.UseCases.MediumUser.Commands;

namespace Medium.Application.UseCases.MediumUser.Handler.Command
{
    public class DeleteUserCommandHandler : AsyncRequestHandler<DeleteUserCommand>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public DeleteUserCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        protected override async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = _applicationDbContext.Users.FirstOrDefault(x => x.Id == request.Id);
            _applicationDbContext.Users.Remove(user);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
