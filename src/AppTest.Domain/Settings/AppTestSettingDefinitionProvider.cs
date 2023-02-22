using Volo.Abp.Settings;

namespace AppTest.Settings;

public class AppTestSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AppTestSettings.MySetting1));
    }
}
