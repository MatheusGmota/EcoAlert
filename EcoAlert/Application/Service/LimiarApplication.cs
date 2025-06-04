using EcoAlert.Application.Dtos;
using EcoAlert.Application.Interfaces;
using EcoAlert.Domain.Entities;
using EcoAlert.Domain.Interfaces;

namespace EcoAlert.Application.Service
{
    public class LimiarApplication : ILimiarApplication
    {

        private readonly ILimiarRepository _limiarRepository;

        public LimiarApplication(ILimiarRepository limiarRepository) {
            _limiarRepository = limiarRepository;
        }

        public LimiarEntity? DeletarDados(int id)
        {
            return _limiarRepository.DeletarDados(id);
        }

        public LimiarEntity? EditarDados(int id, LimiarDto entity)
        {
            var limiarEntity = new LimiarEntity
            {
                Id = id,
                ParametroSensor = entity.ParametroSensor,
                RecomendacaoAlerta = entity.RecomendacaoAlerta,
                MsgMax = entity.MsgMax,
                MsgMin = entity.MsgMin,
                ValorMax = entity.ValorMax,
                ValorMin = entity.ValorMin
            };

            return _limiarRepository.EditarDados(limiarEntity);

        }

        public LimiarEntity? ObterPorId(int id)
        {
            return _limiarRepository.ObterPorId(id);
        }

        public IEnumerable<LimiarEntity>? ObterTodos()
        {
            return _limiarRepository.ObterTodos() ?? Enumerable.Empty<LimiarEntity>();
        }

        public LimiarEntity? SalvarDados(LimiarDto entity)
        {
            var limiarEntity = new LimiarEntity
            {
                ParametroSensor = entity.ParametroSensor,
                RecomendacaoAlerta = entity.RecomendacaoAlerta,
                MsgMax = entity.MsgMax,
                MsgMin = entity.MsgMin,
                ValorMax = entity.ValorMax,
                ValorMin = entity.ValorMin
            };

            return _limiarRepository.SalvarDados(limiarEntity);
        }

    }
}
