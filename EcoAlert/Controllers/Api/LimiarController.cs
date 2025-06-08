using EcoAlert.Application.Dtos;
using EcoAlert.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Swashbuckle.AspNetCore.Annotations; // Importante: Adicione este using

namespace EcoAlert.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LimiarController : ControllerBase
    {
        private readonly ILimiarApplication _service;

        public LimiarController(ILimiarApplication service)
        {
            _service = service;
        }

        /// <summary>
        /// Obtém todos os limiares cadastrados no sistema.
        /// </summary>
        /// <returns>Uma lista de LimiarDto.</returns>
        [HttpGet]
        [SwaggerOperation(
            Summary = "Obtém todos os limiares",
            Description = "Retorna uma lista completa de todos os limiares de alerta configurados no sistema.",
            Tags = new[] { "Limiares" } // Opcional: Para agrupar endpoints no Swagger UI
        )]
        [SwaggerResponse((int)HttpStatusCode.OK, "Lista de limiares obtida com sucesso.", typeof(IEnumerable<LimiarDto>))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro inesperado.")]
        public IActionResult GetAll()
        {
            var limiares = _service.ObterTodos();
            return Ok(limiares);
        }

        /// <summary>
        /// Obtém um limiar específico pelo seu ID.
        /// </summary>
        /// <param name="id">O ID do limiar a ser obtido.</param>
        /// <returns>O LimiarDto correspondente ao ID.</returns>
        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Obtém um limiar por ID",
            Description = "Retorna os detalhes de um limiar específico com base no seu identificador único.",
            Tags = new[] { "Limiares" }
        )]
        [SwaggerResponse((int)HttpStatusCode.OK, "Limiar encontrado com sucesso.", typeof(LimiarDto))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, "Limiar não encontrado.")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro inesperado.")]
        public IActionResult GetById(int id)
        {
            var limiar = _service.ObterPorId(id);
            if (limiar == null)
            {
                return NotFound();
            }
            return Ok(limiar);
        }

        /// <summary>
        /// Cria um novo limiar no sistema.
        /// </summary>
        /// <param name="request">Os dados do limiar a ser criado.</param>
        /// <returns>O LimiarDto criado.</returns>
        [HttpPost]
        [SwaggerOperation(
            Summary = "Cria um novo limiar",
            Description = "Adiciona um novo limiar de alerta ao sistema com os dados fornecidos.",
            Tags = new[] { "Limiares" }
        )]
        [SwaggerResponse((int)HttpStatusCode.OK, "Limiar criado com sucesso.", typeof(LimiarDto))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Dados inválidos fornecidos.", typeof(object))] // Use object para erro genérico
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro inesperado.")]
        public IActionResult Create([FromBody] LimiarDto request)
        {
            try
            {
                var response = _service.SalvarDados(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        /// <summary>
        /// Atualiza um limiar existente pelo seu ID.
        /// </summary>
        /// <param name="id">O ID do limiar a ser atualizado.</param>
        /// <param name="request">Os novos dados para o limiar.</param>
        /// <returns>O LimiarDto atualizado.</returns>
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Atualiza um limiar existente",
            Description = "Modifica os dados de um limiar existente com base no seu ID.",
            Tags = new[] { "Limiares" }
        )]
        [SwaggerResponse((int)HttpStatusCode.OK, "Limiar atualizado com sucesso.", typeof(LimiarDto))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, "Limiar não encontrado para atualização.")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Dados inválidos fornecidos ou erro na atualização.", typeof(object))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro inesperado.")]
        public IActionResult Edit([FromRoute] int id, [FromBody] LimiarDto request)
        {
            try
            {
                var limiarAtualizado = _service.EditarDados(id, request);

                if (limiarAtualizado is not null)
                    return Ok(limiarAtualizado);

                return NotFound($"Limiar não encontrado.");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = ex.Message,
                });
            }
        }

        /// <summary>
        /// Deleta um limiar específico pelo seu ID.
        /// </summary>
        /// <param name="id">O ID do limiar a ser deletado.</param>
        /// <returns>Mensagem de sucesso ou erro.</returns>
        [HttpDelete("{id}")] // Adicione {id} para que o ID venha da rota
        [SwaggerOperation(
            Summary = "Deleta um limiar",
            Description = "Remove um limiar de alerta do sistema usando seu ID.",
            Tags = new[] { "Limiares" }
        )]
        [SwaggerResponse((int)HttpStatusCode.OK, "Limiar deletado com sucesso.", typeof(string))] // Usamos string pois o retorno é uma mensagem
        [SwaggerResponse((int)HttpStatusCode.NotFound, "Limiar não encontrado para exclusão.")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Erro na exclusão do limiar.", typeof(object))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Ocorreu um erro inesperado.")]
        public IActionResult Delete(int id)
        {
            try
            {
                var limiar = _service.ObterPorId(id);

                if (limiar is not null)
                {
                    _service.DeletarDados(id);
                    return Ok($"Limiar com ID {id} deletado com sucesso.");
                }
                return NotFound($"Limiar não encontrado.");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = ex.Message,
                });
            }
        }
    }
}