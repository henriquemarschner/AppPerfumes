using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPerfumes.Models
{
    public class Avaliacao
    {
        public int id;
        public int perfumeId;
        public Perfume perfume;

        public decimal notaGeral;
        public decimal notaFixacao;
        public decimal notaProjecao;
        public decimal notaCustoBeneficio;
        public DateTime AvaliadoEm;
    

    public Avaliacao()
        {
            nome = string.Empty;
            marca = string.Empty;
            ocasiao = string.Empty;
            tempIdeal = string.Empty;
            notaBase = string.Empty;
            notaFixacao = string.Empty;
            notaProjecao = string.Empty;
            notaCustoBeneficio = string.Empty;
            preco = 0;
            AvaliadoEm = DateTime.Now;
            id = new Random().Next(1, 10000);
            perfumeId = 0;
        }
        public Avaliacao(string nome, string marca, string ocasiao, string tempIdeal, string notaGeral, string notaFixacao, string notaProjecao, string notaCustoBeneficio, decimal preco, DateTime avaliadoEm, int id, int perfumeId)
        {
            this.nome = nome;
            this.marca = marca;
            this.ocasiao = ocasiao;
            this.tempIdeal = tempIdeal;
            this.notaBase = notaBase;
            this.notaFixacao = notaFixacao;
            this.notaProjecao = notaProjecao;
            this.notaCustoBeneficio = notaCustoBeneficio;
            this.preco = preco;
            this.AvaliadoEm = avaliadoEm;
            this.id = id;
            this.perfumeId = perfumeId;
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

        public string NotaGeral
            {
            get => notaGeral;
            set => notaGeral = value;
        }

        public string NotaFixacao
            {
            get => notaFixacao;
            set => notaFixacao = value;
        }

        public string NotaProjecao
            {
            get => notaProjecao;
            set => notaProjecao = value;
        }

        public string NotaCustoBeneficio
            {
            get => notaCustoBeneficio;
            set => notaCustoBeneficio = value;
        }
    } 
}