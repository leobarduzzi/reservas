using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace reservas.Models
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public List<ValorAnuncio> ValoresAnuncio { get; set; }
    }
}