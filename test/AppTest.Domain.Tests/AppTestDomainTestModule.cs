using AppTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AppTest;

[DependsOn(
    typeof(AppTestEntityFrameworkCoreTestModule)
    )]
public class AppTestDomainTestModule : AbpModule
{

}
