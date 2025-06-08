using EcoAlert.Application.Dtos;
using EcoAlert.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        [HttpGet]
        public IActionResult GetAll()
        {
            var limiares = _service.ObterTodos();
            return Ok(limiares);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var limiar = _service.ObterPorId(id);
            if (limiar == null)
            {
                return NotFound();
            }
            return Ok(limiar);
        }

        [HttpPost]
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

        [HttpPut("{id}")]
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
                return BadRequest(new {
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = ex.Message,
                });
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var limiar = _service.ObterPorId(id);

                if (limiar is not null) {
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
