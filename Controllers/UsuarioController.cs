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

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> UsuarioPorId(int id)
        {
            UsuarioModel usuario = await _usuarioRepositorio.UsuarioPorId(id);
            return Ok(usuario);
        }


        [HttpPut]
        public async Task<ActionResult<List<UsuarioModel>>> SetUsuarios([FromBody] UsuarioModel usuarioModel)
        {
            List<UsuarioModel> usuario = await _usuarioRepositorio.SetUsuarios(usuarioModel);
            return Ok(usuario);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<UsuarioModel>> UpdateUsuarios([FromBody] UsuarioModel usuarioModel, int id)
        {
            usuarioModel.id = id;
            UsuarioModel usuario = await _usuarioRepositorio.UpdateUsuarios(usuarioModel, id);
            return Ok(usuario);
        }
    }
}
