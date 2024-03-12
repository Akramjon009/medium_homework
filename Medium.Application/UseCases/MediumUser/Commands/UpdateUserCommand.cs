using MediatR;
using Medium.Domain.DTOs;
using Medium.Domain.Entities;

namespace Medium.Application.UseCases.MediumUser.Commands
{
    public class UpdateUserCommand : UserDTO, IRequest<User>
    {
     
        public Guid Id { get; internal set; }
    }
}
