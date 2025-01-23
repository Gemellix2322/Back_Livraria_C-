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

        async Task<List<LivrosModel>> ILivrosRepositorio.SetLivros(LivrosModel livros)
        {
            _dbContext.livros.Add(livros);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.livros.ToListAsync() ;
        }

        async Task<LivrosModel> ILivrosRepositorio.LivrosPorId(int id)
        {
            return await _dbContext.livros.FirstOrDefaultAsync(x => x.id == id);
        }

        async Task<LivrosModel> ILivrosRepositorio.UpdateLivros(LivrosModel newLivro, int id)
        {
            LivrosModel livroPorId = await _dbContext.livros.FirstOrDefaultAsync(x => x.id == id);

            if(livroPorId == null)
            {
                throw new Exception($"Livro por id: {id} não foi encontrado");
            }

            livroPorId.name = newLivro.name;
            livroPorId.description = newLivro.description;
            livroPorId.genre = newLivro.genre;
            livroPorId.cover_image = newLivro.cover_image;

            _dbContext.livros.Update(livroPorId);
            await _dbContext.SaveChangesAsync();
            return livroPorId;
        }
    }
}
