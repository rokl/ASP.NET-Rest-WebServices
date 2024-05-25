﻿using Microsoft.AspNetCore.Mvc;

namespace ProgByte.CRM.Rest.WebServices.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    public class AccountController : BaseController
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public AccountController(IConfiguration configuration) : base(configuration)
        {

        }
    }
}