using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace EcoAlert.Domain.Entities
{
    [Table("tb_limiar_climatico")]
    public class LimiarEntity
    {
        [Key]
        public int Id { get; set; }
        public string ParametroSensor { get; set; }
        public Double ValorMax { get; set; }
        public Double ValorMin { get; set; }
        public string MsgMax { get; set; }
        public string MsgMin { get; set; }
        public string RecomendacaoAlerta { get; set; }
    }
}
