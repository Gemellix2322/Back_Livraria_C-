﻿using back_teste.Model;

namespace BackLivrariaTeste.Repositorios.Interfaces
{
    public interface IMessageRepositorio
    {
        Task<List<MessagesModel>> GetMessages();
    }
}
