using System;
using System.Collections.Generic;
using System.Text;
using AppTest.Localization;
using Volo.Abp.Application.Services;

namespace AppTest;

/* Inherit your application services from this class.
 */
public abstract class AppTestAppService : ApplicationService
{
    protected AppTestAppService()
    {
        LocalizationResource = typeof(AppTestResource);
    }
}
