using Microsoft.AspNetCore.Antiforgery;
using Hyhrobot.WebManagement.Controllers;

namespace Hyhrobot.WebManagement.Web.Host.Controllers
{
    public class AntiForgeryController : WebManagementControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
