using back_teste.Model;
using back_teste.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace back_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> GetUsuarios([FromServices] IUsuarioRepositorio usuarioRepositorio)
        {
            List<UsuarioModel> usuarios = await usuarioRepositorio.GetUsuarios();
            return Ok(usuarios);
        }
    }
}
