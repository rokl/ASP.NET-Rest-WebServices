using Microsoft.AspNetCore.Mvc;

namespace ProgByte.CRM.Rest.WebServices.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly IConfiguration configuration;

        public BaseController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}
