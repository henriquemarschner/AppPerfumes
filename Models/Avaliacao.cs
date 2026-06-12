using ListaPerfumes.Models;

namespace ListaPerfumes.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int PerfumeId { get; set; }
        public Perfume Perfume { get; set; } = null!;

        public decimal NotaGeral { get; set; }
        public decimal NotaFixacao { get; set; }
        public decimal NotaProj { get; set; }
        public decimal NotaCxB { get; set; }
        public string? Comentario { get; set; }
        public DateTime AvaliadoEm { get; set; } = DateTime.Now;
    }
}