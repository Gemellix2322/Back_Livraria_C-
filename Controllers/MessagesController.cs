using back_teste.Model;
using back_teste.Repositorios.Interfaces;
using BackLivrariaTeste.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace back_teste.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {

        private readonly IMessageRepositorio _messageRepositorio;

        public MessagesController(IMessageRepositorio messageRepositorio)
        {
            _messageRepositorio = messageRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<MessagesModel>>> GetMessages([FromServices] IMessageRepositorio messageRepositorio)
        {
            List<MessagesModel> messages = await messageRepositorio.GetMessages();
            return Ok(messages);
        }

        [HttpPut]
        public async Task<ActionResult<List<MessagesModel>>> SetMessages([FromBody] MessagesModel messagesModel)
        {
            List<MessagesModel> message = await _messageRepositorio.SetMessages(messagesModel);
            return Ok(message);
        }
    }
}
