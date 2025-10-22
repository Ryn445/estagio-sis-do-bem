using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SistemaONG.Models
{
    public class Campanha
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(250)]
        public string Descricao { get; set; }
        public DateTime DataDeInicio { get; set; }
        public DateTime DataDeTermino { get; set; }
        public decimal MetaFinanceira { get; set; }
        public decimal TotalArrecadado { get; set; }
        public string Status { get; set; } // Ativa, Concluída, Cancelada
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;
        public DateTime DataDeAtualizacao { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return Nome;
        }
    }
}