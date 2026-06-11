using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPerfumes.Models
{
    public class Wishlist
    {
        public int id;
        public int perfumeId;
        public Perfume perfume;

        public int prioridade;
        public decimal? precoAtualPY;
        public DateTime? ultimaConsultaPreco;
        public string? obs;
        public DateTime adcEm;

    public Wishlist()
        {
            id = 0;
            perfumeId = 0;
            prioridade = 0;
            precoAtualPY = null;
            ultimaConsultaPreco = null;
            obs = null;
            adcEm = DateTime.Now;
            ultimaConsultaPreco = null;
        }
        public Wishlist(int perfumeId, int prioridade, decimal? precoAtualPY, DateTime? ultimaConsultaPreco, string? obs, DateTime adcEm)
        {
            this.perfumeId = perfumeId;
            this.prioridade = prioridade;
            this.precoAtualPY = precoAtualPY;
            this.ultimaConsultaPreco = ultimaConsultaPreco;
            this.obs = obs;
            this.adcEm = adcEm;
        }

        public int PerfumeId
        {
            get => perfumeId;
            set => perfumeId = value;
        }

        public int Prioridade
        {
            get => prioridade;
            set => prioridade = value;
        }

            public decimal? PrecoAtualPY
            {
                get => precoAtualPY;
                set => precoAtualPY = value;
            }
    
            public DateTime? UltimaConsultaPreco
            {
                get => ultimaConsultaPreco;
                set => ultimaConsultaPreco = value;
            }
    
            public string? Obs
            {
                get => obs;
                set => obs = value;
            }
    
            public DateTime AdcEm
            {
                get => adcEm;
                set => adcEm = value;
        }
    }
}
