using back_teste.Model;

namespace BackLivrariaTeste.Repositorios.Interfaces
{
    public interface ILivrosRepositorio
    {
        Task<List<LivrosModel>> GetLivros();

        Task<List<LivrosModel>> SetLivros(LivrosModel livros);
    }
}
