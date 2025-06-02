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
        public int Id;
        public string ParametroSensor = string.Empty;
        public Double ValorMax;
        public Double ValorMin;
        public string MsgMax = string.Empty;
        public string MsgMin = string.Empty;
        public string RecomendacaoAlerta = string.Empty;
    }
}
