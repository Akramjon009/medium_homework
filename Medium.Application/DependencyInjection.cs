using MediatR;
using Medium.Application.Absatractions.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Medium.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddMediatR(Assembly.GetExecutingAssembly());
            service.AddAutoMapper(typeof(AutoMapperProfile));
            return service;
        }
    }
}
