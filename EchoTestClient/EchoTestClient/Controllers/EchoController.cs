using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EchoTestClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        private readonly ILogger<EchoController> _logger;

        public EchoController(ILogger<EchoController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(SimpleMessage simpleMessage)
        {
            _logger.LogInformation(simpleMessage.Message);
        }
    }

    public class SimpleMessage
    {
        public string Message { get; set; }
    }
}
