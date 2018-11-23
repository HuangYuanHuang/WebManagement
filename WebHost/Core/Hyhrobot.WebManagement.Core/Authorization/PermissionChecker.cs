using Abp.Authorization;
using Hyhrobot.WebManagement.Authorization.Roles;
using Hyhrobot.WebManagement.Authorization.Users;

namespace Hyhrobot.WebManagement.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
