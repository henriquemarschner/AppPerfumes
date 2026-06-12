namespace ListaPerfumes.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public int PerfumeId { get; set; }
        public Perfume Perfume { get; set; } = null!;

        public int Prioridade { get; set; }
        public decimal? PrecoAlvo { get; set; }
        public decimal? PrecoAtualPY { get; set; }
        public DateTime? UltimaConsultaPreco { get; set; }
        public string? Obs { get; set; }
        public DateTime AdcEm { get; set; } = DateTime.Now;
    }
}