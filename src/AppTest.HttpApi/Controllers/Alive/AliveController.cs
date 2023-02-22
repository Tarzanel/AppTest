using AppTest.Alive;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace AppTest.Controllers.Alive
{
    
    [RemoteService]
    [Area("app")]
    [ControllerName("Alive")]
    [Route("api/app/alive")]
    public class AliveController : AbpController, IAliveAppService
    {
        private readonly IAliveAppService _aliveAppService;

        public AliveController(IAliveAppService aliveAppService)
        {
            _aliveAppService = aliveAppService; 
        }

        
        [HttpGet]
        [Route("call-alive")]
        public Task<string> CallAlive()
        {
            return _aliveAppService.CallAlive();
        }
    }
}
