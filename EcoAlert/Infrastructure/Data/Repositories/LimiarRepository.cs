using EcoAlert.Domain.Entities;
using EcoAlert.Domain.Interfaces;

namespace EcoAlert.Infrastructure.Data.Repositories
{
    public class LimiarRepository : ILimiarRepository
    {
        public IEnumerable<LimiarEntity>? ObterTodos()
        {
            return null;
        }
        public LimiarEntity? ObterPorId(int id)
        {
            return null;
        }
        public LimiarEntity? SalvarDados(LimiarEntity entity)
        {
            return null;
        }
        public LimiarEntity? EditarDados(LimiarEntity entity)
        {
            return null;
        }
        public LimiarEntity? DeletarDados(int id)
        {
            return null;
        }
    }
}
