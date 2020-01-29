using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace reservas.Models
{
    public class Disponibilidade
    {
        public int Id { get; set; }
        public int AnuncioId { get; set; }
        public Anuncio Anuncio { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        
        public int Reservados { get; set; }

        public bool Disponivel { get; set; }
        
    }
}