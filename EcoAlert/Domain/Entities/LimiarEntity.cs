using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoAlert.Domain.Entities
{
    [Table("TB_LIMIAR_CLIMATICO")]
    public class LimiarEntity
    {
        [Key]
        [Column("ID_LIMIAR")]
        public int Id { get; set; }

        [Column("PARAMETRO_SENSOR")]
        public string ParametroSensor { get; set; }
        
        [Column("VALOR_MAX")]
        public Double ValorMax { get; set; }
        
        [Column("VALOR_MIN")]
        public Double ValorMin { get; set; }
        
        [Column("MSG_MAX")]
        public string MsgMax { get; set; }

        [Column("MSG_MIN")]
        public string MsgMin { get; set; }
        
        [Column("RECOMENDACAO_ALERTA")]
        public string RecomendacaoAlerta { get; set; }
    }
}
