using ListaPerfumes.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPerfumes.Models
{
    public class ColecaoItem
    {
        public int id;
        public int perfumeId;
        public Perfume perfume;

        public DateTime adicionadoEm;
        public Status statsCol;
        public int? MLComprado;
        public int? MLRestante;
        public decimal? precoPago;
        public DateTime? dataCompra;

        public ColecaoItem()
        {
            adicionadoEm = DateTime.Now;
            id = new Random().Next(1, 10000);
            perfumeId = 0;
            statsCol = Status.NaoAvaliado;
            MLComprado = 0;
            MLRestante = 0;
            precoPago = 0;
            dataCompra = null;
        }
        public ColecaoItem(int perfumeId, DateTime adicionadoEm, int id, int? MLComprado, int? MLRestante, decimal? precoPago, DateTime? dataCompra)
        {
            this.perfumeId = perfumeId;
            this.adicionadoEm = adicionadoEm;
            this.id = id;
            this.statsCol = Status.NaoAvaliado;
            this.MLComprado = MLComprado;
            this.MLRestante = MLRestante;
            this.precoPago = precoPago;
            this.dataCompra = dataCompra;
        }

        public int PerfumeId
        {
            get => perfumeId;
            set => perfumeId = value;
        }

        public DateTime AdicionadoEm
        {
            get => adicionadoEm;
            set => adicionadoEm = value;
        }
         public Status StatsCol
        {
            get => statsCol;
            set => statsCol = value;
        }
         public int? MLComprado1
        {
            get => MLComprado;
            set => MLComprado = value;
        }
         public int? MLRestante1
        {
            get => MLRestante;
            set => MLRestante = value;
        }
         public decimal? PrecoPago
        {
            get => precoPago;
            set => precoPago = value;
        }
         public DateTime? DataCompra
        {
            get => dataCompra;
            set => dataCompra = value;
        }
    }
}
