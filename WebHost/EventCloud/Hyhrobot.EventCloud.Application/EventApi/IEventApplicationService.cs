using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;

namespace Hyhrobot.EventCloud.Application.EventApi
{
    public interface IEventApplicationService : IApplicationService
    {
        int UpdateTask(string input);
        int CreateTask(string input);
    }
}
