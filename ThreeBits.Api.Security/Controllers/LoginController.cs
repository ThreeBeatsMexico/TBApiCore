using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ThreeBits.Entities.Security;
using ThreeBits.Interfaces.Security;

namespace ThreeBits.Api.Security.Controllers
{
    [EnableCors("ThreeBitsCorsPolicy")]
    [ApiController]
    [Route("api/v1/Security")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ISecurityService _service;
        HttpContext context;

        public LoginController(ILogger<LoginController> logger, ISecurityService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Login")]
        public ActionResult ObtenerEstatusFormulario([FromBody] Credential input)
        {
            if (context.Request.Headers.TryGetValue("XAPPID", out var sXAPPID))
            {
                input.xAppId = sXAPPID;
            }
            else { 
            
            
            }


            return Ok(_service.Login(input));
        }


    }
}
