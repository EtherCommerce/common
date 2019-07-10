using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EtherCommerce.Common.Redis
{
    public static class Extensions
    {
        public static void AddRedisCache(this IServiceCollection services, IConfiguration configuration)
        {
            var options = new RedisOptions();
            var section = configuration.GetSection("redis");
            section.Bind(options);

            services.Configure<RedisOptions>(section);

            services.AddDistributedRedisCache(x =>
            {
                x.Configuration = options.ConnectionString;
            });
        }
    }
}
