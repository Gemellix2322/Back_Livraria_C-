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
        [HttpGet]
        public async Task<ActionResult<List<MessagesModel>>> GetMessages([FromServices] IMessageRepositorio messageRepositorio)
        {
            List<MessagesModel> messages = await messageRepositorio.GetMessages();
            return Ok(messages);
        }
    }
}
