using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using DefautIServiceCollectionExtensions = R5T.D0032.Default.IServiceCollectionExtensions;


namespace R5T.D0032.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IUserNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddUserNameProvider(this IServiceCollection services)
        {
            var userNameProviderAction = services.AddUserNameProviderAction();

            services.Run(userNameProviderAction);

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IUserNameProvider"/> service.
        /// </summary>
        public static IServiceAction<IUserNameProvider> AddUserNameProviderAction(this IServiceCollection services)
        {
            var userNameProviderAction = DefautIServiceCollectionExtensions.AddUserNameProviderAction(services);

            return userNameProviderAction;
        }
    }
}
