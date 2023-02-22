using Volo.Abp.Modularity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.VirtualFileSystem;

namespace AppTest.Payment
{ 
    public class AppTestPaymentModule: AbpModule
    {    

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AppTestPaymentModule>();
            });
    
            var configuration = context.Services.GetConfiguration();       

            ConfigurePowerTranzPayment(context, configuration);            
        }
        private void ConfigurePowerTranzPayment(ServiceConfigurationContext context, IConfiguration configuration)
        {
            var powerTranzId = configuration["PowerTranzPaymentClient:PowerTranzId"];
            var powerTranzPassword = configuration["PowerTranzPaymentClient:PowerTranzPassword"];

            context.Services.AddPowerTranzPaymentGateway(options =>
            {                
                options.PowerTranzPassword = powerTranzPassword;
                options.PowerTranzId = powerTranzId;
            });            
        }
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {

        }
    }
}
