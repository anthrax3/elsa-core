using Elsa.Dashboard.Middleware;
using Elsa.Dashboard.Options;
using Elsa.Runtime;
using Elsa.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Elsa.Dashboard.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddElsaDashboard(this IServiceCollection services)
        {
            services
                .AddTaskExecutingServer()
                .AddSingleton<IIdGenerator, IdGenerator>()
                .AddScoped<IWorkflowPublisher, WorkflowPublisher>()
                .AddTransient<DashboardMiddleware>();
            
            services.ConfigureOptions<StaticAssetsConfigureOptions>();

            return services;
        }
    }
}