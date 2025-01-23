using back_teste.Model;
using BackLivrariaTeste.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace back_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<LivrosModel>>> GetLivros([FromServices] ILivrosRepositorio livrosRepositorio)
        {
            List<LivrosModel> livros = await livrosRepositorio.GetLivros();
            return Ok(livros);
        }
    }
}
