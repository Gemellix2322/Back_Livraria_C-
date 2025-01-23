using back_teste.Model;
using back_teste.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace back_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> GetUsuarios([FromServices] IUsuarioRepositorio usuarioRepositorio)
        {
            List<UsuarioModel> usuarios = await usuarioRepositorio.GetUsuarios();
            return Ok(usuarios);
        }


        [HttpPut]
        public async Task<ActionResult<List<UsuarioModel>>> SetUsuarios([FromBody] UsuarioModel usuarioModel)
        {
            List<UsuarioModel> usuario = await _usuarioRepositorio.SetUsuarios(usuarioModel);
            return Ok(usuario);
        }
    }
}
