using AutoMapper;
using MediatR;
using Medium.Application.Absatractions;
using Medium.Application.UseCases.MediumUser.Commands;
using Medium.Domain.DTOs;
using Medium.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medium.Application.UseCases.MediumUser.Handler.Command
{
    public class UpdateUserCommandHandler(IApplicationDbContext _applicationDbContext, IMapper _mapper) : IRequestHandler<UpdateUserCommand, User>
    {
        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted != true);
            if (user != null)
            {
                _mapper.Map<User>(request);
                await _applicationDbContext.SaveChangesAsync();

                return user;
            }
            return null;
        }


    }
}
