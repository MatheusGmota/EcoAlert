using EcoAlert.Application.Dtos;
using EcoAlert.Application.Interfaces;
using EcoAlert.Domain.Entities;

namespace EcoAlert.Application.Service
{
    public class LimiarApplication : ILimiarApplication
    {
        public LimiarEntity? DeletarDados(int id)
        {
            throw new NotImplementedException();
        }

        public LimiarEntity? EditarDados(LimiarDto entity)
        {
            throw new NotImplementedException();
        }

        public LimiarEntity? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LimiarEntity>? ObterTodos()
        {
            throw new NotImplementedException();
        }

        public LimiarEntity? SalvarDados(LimiarDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
