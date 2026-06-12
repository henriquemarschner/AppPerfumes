using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPerfumes.Models
{
    public class Contratipo
    {
        public int Id { get; set; }
        public int PerfumeOGId { get; set; }
        public Perfume PerfumeOG { get; set; }
        public int PerfumeCTId { get; set; }
        public Perfume PerfumeCT { get; set; }
        public int SimilarPCT { get; set; }
        public string? NotasDiferenca { get; set; }
    }

}
