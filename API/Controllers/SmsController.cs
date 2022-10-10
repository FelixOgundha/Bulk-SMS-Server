using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SmsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SmsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> sendSms()
        {
            var gateway = new AfricasTalkingGateway("sandbox", "fbf273995f2749dc3802c863863b8ad9219af1cf815f767a0fdc933f649e870e");

            string to = "0718627569";
            string message = "this is felix";

            var result = gateway.SendMessage(to, message);

            return Ok(result);
        } 
    }
}
