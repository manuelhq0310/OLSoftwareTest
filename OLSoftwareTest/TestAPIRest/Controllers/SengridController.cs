using Microsoft.AspNetCore.Mvc;
using TestAPIRest.Models;
using TestAPIRest.Services;

namespace TestAPIRest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SengridController : ControllerBase
    {
        private readonly SendGridService _sendGridService;

        public SengridController(SendGridService sendGridService)
        {
            _sendGridService = sendGridService;
        }

        [HttpPost]
        public ActionResult SendEmail([FromBody] SendEmail requestSendEmail)
        {
            _sendGridService.SendEmail(requestSendEmail);
            return Ok();
        }
    }
}
