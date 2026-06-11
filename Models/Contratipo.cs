using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPerfumes.Models
{
    public class Contratipo
    {
        public int id;
        public int perfumeOGId;
        public Perfume perfumeOG;
        public int perfumeCTId;
        public Perfume perfumeCT;
        public int SimilarPCT;
        public string? NotasDiferenca;

    public Contratipo()
        {
            id = new Random().Next(1, 10000);
            perfumeOGId = 0;
            perfumeCTId = 0;
            SimilarPCT = 0;
            NotasDiferenca = null;
        }

    public Contratipo(int perfumeOGId, int perfumeCTId, int similarPCT, string? notasDiferenca)
        {
            id = new Random().Next(1, 10000);
            this.perfumeOGId = perfumeOGId;
            this.perfumeCTId = perfumeCTId;
            this.SimilarPCT = similarPCT;
            this.NotasDiferenca = notasDiferenca;
        }
         public int PerfumeOGId
        {
            get => perfumeOGId;
            set => perfumeOGId = value;
        }
         public int PerfumeCTId
        {
            get => perfumeCTId;
            set => perfumeCTId = value;
        }
         public int SimilarPCT1
        {
            get => SimilarPCT;
            set => SimilarPCT = value;
        }
         public string? NotasDiferenca1
        {
            get => NotasDiferenca;
            set => NotasDiferenca = value;
        }
    }

}
