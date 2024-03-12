using MediatR;

namespace Medium.Application.UseCases.MediumUser.Commands
{
    public class DeleteUserCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
