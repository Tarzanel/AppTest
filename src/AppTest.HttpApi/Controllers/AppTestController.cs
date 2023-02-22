using AppTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AppTest.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AppTestController : AbpControllerBase
{
    protected AppTestController()
    {
        LocalizationResource = typeof(AppTestResource);
    }
}
