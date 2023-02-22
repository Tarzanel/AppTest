using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace AppTest.Alive
{
    public interface IAliveAppService: IApplicationService
    {
        Task<string> CallAlive();
    }
}
