using ListaPerfumes.Models.Enums;

namespace ListaPerfumes.Models
{
    public class Perfume
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Marca { get; set; } = "";
        public TipoPerfume Tipo { get; set; }
        public FmlOlfativa FmlOlfativa { get; set; }
        public string Ocasiao { get; set; } = "";
        public string TempIdeal { get; set; } = "";
        public string NotaTopo { get; set; } = "";
        public string NotaCoracao { get; set; } = "";
        public string NotaBase { get; set; } = "";
        public string Fixacao { get; set; } = "";
        public string Proj { get; set; } = "";
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public string? Inspirado { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        public List<Avaliacao> Avaliacoes { get; set; } = new();
        public ColecaoItem? ColecaoItem { get; set; }
        public Wishlist? Wishlist { get; set; }
    }
}