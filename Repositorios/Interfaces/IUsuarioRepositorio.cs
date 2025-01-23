using back_teste.Model;

namespace back_teste.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> GetUsuarios();

        Task<List<UsuarioModel>> SetUsuarios(UsuarioModel usuario);
    }
}
