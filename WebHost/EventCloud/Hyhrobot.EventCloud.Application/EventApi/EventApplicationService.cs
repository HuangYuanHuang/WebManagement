using Abp.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hyhrobot.EventCloud.Application.EventApi
{
  //  [ApiVersion("2")]
    public class EventApplicationService : ApplicationService, IEventApplicationService
    {
        
        public int CreateTask(string input)
        {
            return 1;
        }

        public int UpdateTask(string input)
        {
            return 1;
        }
    }
}
