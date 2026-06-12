using ListaPerfumes.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPerfumes.Models
{
    public class ColecaoItem
    {
        public int Id { get; set; }
        public int PerfumeId { get; set; }
        public Perfume Perfume { get; set; }= new Perfume();

        public DateTime AdicionadoEm { get; set; }
        public Status StatsCol { get; set; }
        public int? MLComprado { get; set; }
        public int? MLRestante { get; set; }
        public decimal? PrecoPago { get; set; }
        public DateTime? DataCompra { get; set; }
    }
}
