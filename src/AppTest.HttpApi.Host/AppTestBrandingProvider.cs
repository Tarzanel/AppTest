using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AppTest;

[Dependency(ReplaceServices = true)]
public class AppTestBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AppTest";
}
