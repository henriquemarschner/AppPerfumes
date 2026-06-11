using ListaPerfumes.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPerfumes.Models
{
    public class Perfume
    {
        public int id;
        public string nome;
        public string marca;
        public TipoPerfume tipo;
        public FmlOlfativa fmlOlfativa;
        public string ocasiao;
        public string tempIdeal;
        public string notaTopo;
        public string notaCoracao;
        public string notaBase;
        public string fixacao;
        public string proj;
        public decimal preco;
        public string? imagemUrl;
        public string? inspirado;
        public DateTime criadoEm;

        public List<Avaliacao> Avaliacoes;
        public ColecaoItem? ColecaoItem;
        public WishlistItem? WishlistItem;

        public Perfume()
        {
            criadoEm = DateTime.Now;
            id = new Random().Next(1, 10000);
            nome = string.Empty;
            marca = string.Empty;
            ocasiao = string.Empty;
            tempIdeal = string.Empty;
            notaTopo = string.Empty;
            notaCoracao = string.Empty;
            notaBase = string.Empty;
            fixacao = string.Empty;
            proj = string.Empty;
            preco = 0;
        }

        public Perfume(string nome, string marca, TipoPerfume tipo, FmlOlfativa fmlOlfativa, string ocasiao, string tempIdeal, string notaTopo, string notaCoracao, string notaBase, string fixacao, string proj, decimal preco, string? imagemUrl = null, string? inspirado = null)
        {
            criadoEm = DateTime.Now;
            id = new Random().Next(1, 10000);
            this.nome = nome;
            this.marca = marca;
            this.tipo = tipo;
            this.fmlOlfativa = fmlOlfativa;
            this.ocasiao = ocasiao;
            this.tempIdeal = tempIdeal;
            this.notaTopo = notaTopo;
            this.notaCoracao = notaCoracao;
            this.notaBase = notaBase;
            this.fixacao = fixacao;
            this.proj = proj;
            this.preco = preco;
            this.imagemUrl = imagemUrl;
            this.inspirado = inspirado;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Marca
        {
            get => marca;
            set => marca = value;
        }

        public TipoPerfume Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public string FmlOlfativa
        {
            get => fmlOlfativa.ToString();
            set
            {
                if (Enum.TryParse(value, out FmlOlfativa result))
                {
                    fmlOlfativa = result;
                }
                else
                {
                    throw new ArgumentException("Valor inválido para FmlOlfativa.");
                }
            }
        }

        public string Ocasiao
        {
            get => ocasiao;
            set => ocasiao = value;
        }

        public string TempIdeal
        {
            get => tempIdeal;
            set => tempIdeal = value;
        }

        public string NotaTopo
        {
            get => notaTopo;
            set => notaTopo = value;
        }

        public string NotaCoracao
        {
            get => notaCoracao;
            set => notaCoracao = value;
        }

        public string NotaBase
        {
            get => notaBase;
            set => notaBase = value;
        }

        public string Fixacao
        {
            get => fixacao;
            set => fixacao = value;
        }

        public string Proj
        {
            get => proj;
            set => proj = value;
        }

        public decimal Preco
        {
            get => preco;
            set => preco = value;
        }

        public string? ImagemUrl
        {
            get => imagemUrl;
            set => imagemUrl = value;
        }

        public string? Inspirado
        {
            get => inspirado;
            set => inspirado = value;
        }

        public DateTime CriadoEm
        {
            get => criadoEm;
            set => criadoEm = value;
        }

        public List<Avaliacao> Avaliacoes
        {
            get => Avaliacoes;
            set => Avaliacoes = value;
        }

        public ColecaoItem? ColecaoItem
            {
                get => ColecaoItem;
                set => ColecaoItem = value;
        }

        public WishlistItem? WishlistItem
        {
            get => WishlistItem;
            set => WishlistItem = value;
        }
    }
}
