using ListaPerfumes.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPerfumes.Models
{
    public class Perfume
    {
        public int Id;
        public string Nome;
        public string Marca;
        public TipoPerfume Tipo;
        public FmlOlfativa FamiliaOlfativa;
        public string Ocasiao;

    }
}
