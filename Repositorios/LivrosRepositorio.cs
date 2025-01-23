using back_teste.Data;
using back_teste.Model;
using BackLivrariaTeste.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackLivrariaTeste.Repositorios
{
    public class LivrosRepositorio : ILivrosRepositorio
    {
        private readonly LivrariaDBContext _dbContext;
        public LivrosRepositorio(LivrariaDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        async Task<List<LivrosModel>> ILivrosRepositorio.GetLivros()
        {
            return await _dbContext.livros.ToListAsync();
        }
    }
}
