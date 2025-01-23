using back_teste.Model;
using Org.BouncyCastle.Asn1.X509;

namespace BackLivrariaTeste.Repositorios.Interfaces
{
    public interface ILivrosRepositorio
    {
        Task<List<LivrosModel>> GetLivros();

        Task<List<LivrosModel>> SetLivros(LivrosModel livros);

        Task<LivrosModel> LivrosPorId(int id);

        Task<LivrosModel> UpdateLivros(LivrosModel newLivro, int id);
    }
}
