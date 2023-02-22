using System.Threading.Tasks;

namespace AppTest.Data;

public interface IAppTestDbSchemaMigrator
{
    Task MigrateAsync();
}
