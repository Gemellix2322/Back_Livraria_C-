using back_teste.Model;

namespace BackLivrariaTeste.Repositorios.Interfaces
{
    public interface IMessageRepositorio
    {
        Task<List<MessagesModel>> GetMessages();

        Task<List<MessagesModel>> SetMessages(MessagesModel message);
    }
}
