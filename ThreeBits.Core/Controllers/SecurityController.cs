using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ThreeBits.WebApi.Controllers
{
    [EnableCors("ThreeBitsCorsPolicy")]
    [ApiController]
    [Route("api/v1/")]
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
