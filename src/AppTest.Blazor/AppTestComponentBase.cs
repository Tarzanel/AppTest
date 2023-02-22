using AppTest.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AppTest.Blazor;

public abstract class AppTestComponentBase : AbpComponentBase
{
    protected AppTestComponentBase()
    {
        LocalizationResource = typeof(AppTestResource);
    }
}
