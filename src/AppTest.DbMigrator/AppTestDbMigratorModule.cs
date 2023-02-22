using AppTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AppTest.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AppTestEntityFrameworkCoreModule),
    typeof(AppTestApplicationContractsModule)
    )]
public class AppTestDbMigratorModule : AbpModule
{

}
