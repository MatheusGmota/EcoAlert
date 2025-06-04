using System.ComponentModel.DataAnnotations;

namespace EcoAlert.Application.Dtos
{
    public class LimiarDto
    {
        [Required(ErrorMessage = $"Campo {nameof(ParametroSensor)} é obrigatorio")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Campo deve ter no minimo 5 caracteres")]
        public string ParametroSensor = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(RecomendacaoAlerta)} é obrigatorio")]
        public string RecomendacaoAlerta = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(ValorMax)} é obrigatorio")]
        public Double ValorMax;

        [Required(ErrorMessage = $"Campo {nameof(ValorMin)} é obrigatorio")]
        public Double ValorMin;
        
        [Required(ErrorMessage = $"Campo {nameof(MsgMax)} é obrigatorio")]
        public string MsgMax = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(MsgMin)} é obrigatorio")]
        public string MsgMin = string.Empty;
        
    }
}
