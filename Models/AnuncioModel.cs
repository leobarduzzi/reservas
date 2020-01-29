using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace reservas.Models
{
    public class Anuncio
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int Quartos { get; set; }
        public int Banheiros { get; set; }

        public int CamaCasal { get; set; } 
        public int CamaSolteiro { get; set; }
        public int Berco { get; set; }
        public int Beliche { get; set; }
        public int Colchoes { get; set; }
        
        public int Quantidade { get; set; }
        public int EstadiaMin { get; set; }

        [DataType(DataType.Time)]
        public DateTime CheckIn { get; set; }
        [DataType(DataType.Time)]
        public DateTime CheckOut { get; set; }
        
        public List<Disponibilidade> Disponibilidades { get; set; }

        public int Ativo { get; set; }

    }
}