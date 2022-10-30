using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Mapping;
using System.Reflection;

namespace ProductApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddAplicationRegistration(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assm);
            services.AddMediatR(assm);
        }
    }
}
