using Microsoft.AspNetCore.Mvc;

namespace ProgByte.CRM.Rest.WebServices.Controllers
{
    /// <summary>
    /// Base controller for all controllers
    /// Here any general configuration should be implemented, to apply them to all controllers
    /// </summary>
    public abstract class BaseController : Controller
    {
        private readonly IConfiguration configuration;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public BaseController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}
