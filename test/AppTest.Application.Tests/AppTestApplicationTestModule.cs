using Volo.Abp.Modularity;

namespace AppTest;

[DependsOn(
    typeof(AppTestApplicationModule),
    typeof(AppTestDomainTestModule)
    )]
public class AppTestApplicationTestModule : AbpModule
{

}
