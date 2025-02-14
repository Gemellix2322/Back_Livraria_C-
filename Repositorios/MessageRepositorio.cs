﻿using back_teste.Data;
using back_teste.Model;
using back_teste.Repositorios.Interfaces;
using BackLivrariaTeste.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackLivrariaTeste.Repositorios
{
    public class MessageRepositorio : IMessageRepositorio
    {
        private readonly LivrariaDBContext _dbContext;

        public MessageRepositorio(LivrariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        async Task<List<MessagesModel>> IMessageRepositorio.GetMessages()
        {
            return await _dbContext.messages.ToListAsync();
        }

        async Task<List<MessagesModel>> IMessageRepositorio.SetMessages(MessagesModel messages)
        {
            _dbContext.messages.Add(messages);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.messages.ToListAsync();
        }

        async Task<MessagesModel> IMessageRepositorio.MessagePorId(int id)
        {
            return await _dbContext.messages.FirstOrDefaultAsync(x => x.id == id);
        }
    }
}
