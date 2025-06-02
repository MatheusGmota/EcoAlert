using EcoAlert.Application.Dtos;
using EcoAlert.Domain.Entities;

namespace EcoAlert.Application.Interfaces
{
    public interface ILimiarApplication
    {
        IEnumerable<LimiarEntity>? ObterTodos();
        LimiarEntity? ObterPorId(int id);
        LimiarEntity? SalvarDados(LimiarDto entity);
        LimiarEntity? EditarDados(LimiarDto entity);
        LimiarEntity? DeletarDados(int id);
    }
}
