using AutoMapper;
using Medium.Application.UseCases.MediumUser.Commands;
using Medium.Domain.Entities;

namespace Medium.Application.Absatractions.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, CreateUserCommand>().ReverseMap();
        }
    }
}
