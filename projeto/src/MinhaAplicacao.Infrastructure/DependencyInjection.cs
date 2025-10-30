using Microsoft.Extensions.DependencyInjection;
using MinhaAplicacao.Application.Interfaces;
using MinhaAplicacao.Application.Services;
using MinhaAplicacao.Domain.Repositories;
using MinhaAplicacao.Infrastructure.Repositories;

namespace MinhaAplicacao.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IEntityRepository, EntityRepository>();
            services.AddScoped<IEntitiesService, EntitiesService>();
        }
    }
}