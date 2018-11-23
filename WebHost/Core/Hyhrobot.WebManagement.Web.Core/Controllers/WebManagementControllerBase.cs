using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Hyhrobot.WebManagement.Controllers
{
    public abstract class WebManagementControllerBase: AbpController
    {
        protected WebManagementControllerBase()
        {
            LocalizationSourceName = WebManagementConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
