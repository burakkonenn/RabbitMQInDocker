using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQInDocker.Database.Models;
using RabbitMQInDocker.Helpers;

namespace RabbitMQInDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EftController : ControllerBase
    {
        [HttpPost("send")]
        public IActionResult SendToMoney([FromBody] SendingEftModel model)
        {
            EftProducerHelper.SendMoney(model);
            return Ok("EFT İsteğiniz listelenmiştir.");
        }
    }
}
