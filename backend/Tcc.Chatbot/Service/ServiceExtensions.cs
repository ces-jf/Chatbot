using Microsoft.Extensions.DependencyInjection;

namespace Tcc.Chatbot.Service
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<AlunoService>();
        }
    }
}