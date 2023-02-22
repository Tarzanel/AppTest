using AppTest.Payment.Api;
using AppTest.Payment.Client;

using Microsoft.Extensions.DependencyInjection;

namespace AppTest.Payment
{
    public static class MHUPaymentExtensions
    {
        public static IServiceCollection AddPowerTranzPaymentGateway(
            this IServiceCollection services, 
            Action<PowerTranzPaymentGatewayOptions> configureOptions)
        {
            var options = new PowerTranzPaymentGatewayOptions();
            configureOptions(options);

            GlobalConfiguration.Initialize(options.PowerTranzId, options.PowerTranzPassword);

            // Add necessary services to the service collection
            services.AddSingleton<IAliveApi, AliveApi>();
            services.AddSingleton<ISpiTransactionsApi, SpiTransactionsApi>();
            services.AddSingleton<ITermMgmtApi, TermMgmtApi>();
            services.AddSingleton<IThreeDSecureApi, ThreeDSecureApi>();
            services.AddSingleton<ITransactionQueriesApi, TransactionQueriesApi>();
            services.AddSingleton<ITransactionsApi, TransactionsApi>();

            return services;
        }
    }

}
