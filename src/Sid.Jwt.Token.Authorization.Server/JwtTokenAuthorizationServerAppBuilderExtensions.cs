using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Sid.Jwt.Token.Authorization.Server
{
    public static class JwtTokenAuthorizationServerAppBuilderExtensions
    {
        public static IServiceCollection AddJwtTokenAuthorizationServer(this IServiceCollection services, Action<JwtTokenAuthorizationServerOptions> configureOptions, Func<IServiceProvider, IUserFinder> implementationFactory = null)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (configureOptions == null)
            {
                throw new ArgumentNullException(nameof(configureOptions));
            }

            // Add Options
            services.AddOptions();
            services.Configure(configureOptions);

            // Add IUserFinder
            if (implementationFactory != null)
            {
                services.AddSingleton<IUserFinder>(implementationFactory);
            }

            return services;
        }

        public static IApplicationBuilder UseJwtTokenAuthorizationServer(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }
            
            return app.UseMiddleware<JwtTokenAuthorizationServerMiddleware>();
        }
    }
}
