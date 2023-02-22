using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AppTest.Alive
{
    public interface IMsgAppService : IApplicationService
    {
        Task<string> SendMsgAsync(string msg);
    }
}
