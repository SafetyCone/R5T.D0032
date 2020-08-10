using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0032.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="UserNameProvider"/> implementation of <see cref="IUserNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddUserNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUserNameProvider, UserNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="UserNameProvider"/> implementation of <see cref="IUserNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IUserNameProvider> AddUserNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IUserNameProvider>(() => services.AddUserNameProvider());
            return serviceAction;
        }
    }
}
