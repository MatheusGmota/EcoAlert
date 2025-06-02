using EcoAlert.Domain.Entities;

namespace EcoAlert.Domain.Interfaces
{
    public interface ILimiarRepository
    {
        IEnumerable<LimiarEntity>? ObterTodos();
        LimiarEntity? ObterPorId(int id);
        LimiarEntity? SalvarDados(LimiarEntity entity);
        LimiarEntity? EditarDados(LimiarEntity entity);
        LimiarEntity? DeletarDados(int id);
    }

}
