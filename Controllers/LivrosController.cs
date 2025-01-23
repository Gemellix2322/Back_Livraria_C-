using back_teste.Model;
using BackLivrariaTeste.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace back_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {

        private readonly ILivrosRepositorio _livrosRepositorio;

        public LivrosController(ILivrosRepositorio livrosRepositorio)
        {
            _livrosRepositorio = livrosRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<LivrosModel>>> GetLivros([FromServices] ILivrosRepositorio livrosRepositorio)
        {
            List<LivrosModel> livros = await livrosRepositorio.GetLivros();
            return Ok(livros);
        }

        [HttpPut]
        public async Task<ActionResult<List<LivrosModel>>> SetLivros([FromBody] LivrosModel livros)
        {
            List<LivrosModel> livro = await _livrosRepositorio.SetLivros(livros);
            return Ok(livro);
        }
    }
}
