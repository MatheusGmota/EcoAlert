using System.ComponentModel.DataAnnotations;

namespace EcoAlert.Application.Dtos
{
    public class LimiarDto
    {
        [Required(ErrorMessage = $"Campo {nameof(ParametroSensor)} é obrigatorio")]
        public string ParametroSensor { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(RecomendacaoAlerta)} é obrigatorio")]
        public string RecomendacaoAlerta { get; set; } = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(ValorMax)} é obrigatorio")]
        public Double ValorMax { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(ValorMin)} é obrigatorio")]
        public Double ValorMin { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(MsgMax)} é obrigatorio")]
        public string MsgMax { get; set; } = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(MsgMin)} é obrigatorio")]
        public string MsgMin { get; set; } = string.Empty;
        
    }
}
