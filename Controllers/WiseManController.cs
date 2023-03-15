using Microsoft.AspNetCore.Mvc;


namespace WiseMan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WiseManController : ControllerBase
    {

        [HttpPost]
        public IActionResult ReceiveWebhook([FromBody] object Payload)
        {
            return Ok();
        }
    }
}
