using System;
using System.ComponentModel.DataAnnotations;

namespace reservas.Models
{
    public class ValorAnuncio
    {
        public int Id { get; set; }
        
        [Required]
        public int AnuncioId { get; set; }
        public Anuncio Anuncio { get; set; }

        [Required]
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public decimal Acrescimo { get; set; }
        public int ParcelaMin { get; set; }
        public int ParcelaMax { get; set; }

        public bool Ativo { get; set; }


    }
}