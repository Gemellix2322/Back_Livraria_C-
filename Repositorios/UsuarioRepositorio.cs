using back_teste.Data;
using back_teste.Model;
using back_teste.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace back_teste.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly LivrariaDBContext _dbContext;

        public UsuarioRepositorio(LivrariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        async Task<List<UsuarioModel>> IUsuarioRepositorio.GetUsuarios()
        {
            return await _dbContext.users.ToListAsync();
        }
    }
}
