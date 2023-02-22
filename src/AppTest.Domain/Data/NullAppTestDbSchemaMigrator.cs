using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AppTest.Data;

/* This is used if database provider does't define
 * IAppTestDbSchemaMigrator implementation.
 */
public class NullAppTestDbSchemaMigrator : IAppTestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
