using EcoAlert.Domain.Entities;
using EcoAlert.Domain.Interfaces;
using EcoAlert.Infrastructure.Data.AppData;

namespace EcoAlert.Infrastructure.Data.Repositories
{
    public class LimiarRepository : ILimiarRepository
    {

        private readonly ApplicationContext _context;

        public LimiarRepository(ApplicationContext context) 
        {
            _context = context;
        }

        public IEnumerable<LimiarEntity>? ObterTodos()
        {
            var limiares = _context.Limiar.ToList();
            if (limiares.Any()) {
                return limiares;
            }
            return null;
        }
        public LimiarEntity? ObterPorId(int id)
        {
            var limiares = _context.Limiar.Find(id);
            if (limiares is not null)
            {
                return limiares;
            }
            return null;
        }
        public LimiarEntity? SalvarDados(LimiarEntity entity)
        {
            try
            {
                _context.Limiar.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possivel salvar os dados limiares");
            }

        }
        public LimiarEntity? EditarDados(LimiarEntity entity)
        {
            try
            {
                var limiar = _context.Limiar.FirstOrDefault(x => x.Id == entity.Id);

                if (limiar is not null)
                {
                    limiar.ParametroSensor = entity.ParametroSensor;
                    limiar.RecomendacaoAlerta = entity.RecomendacaoAlerta;
                    limiar.ValorMax = entity.ValorMax;
                    limiar.ValorMin = entity.ValorMin;
                    limiar.MsgMax = entity.MsgMax;
                    limiar.MsgMin = entity.MsgMin;

                    _context.Limiar.Update(limiar);
                    _context.SaveChanges();

                    return limiar;
                }

                throw new Exception("Não foi possivel localizar o objeto para seguir com a edição");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
        public LimiarEntity? DeletarDados(int id)
        {
            try
            {
                var limiar = _context.Limiar.Find(id);

                if (limiar is not null)
                {
                    _context.Limiar.Remove(limiar);
                    _context.SaveChanges();

                    return limiar;
                }

                throw new Exception("Não foi possivel localizar o objeto para seguir com a exclusão");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
    }
}
