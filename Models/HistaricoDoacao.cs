using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SisDoBem.Models
{
    public class HistoricoDoacao
    {
        public int Id { get; set; }
        [Required]
        public int DoadorId { get; set; }
        [Required]
        public DateTime DataDaDoacao { get; set; }
        [Required]
        public string TipoDeDoacao { get; set; }
        public string MeioDeDoacao { get; set; }
        public Doacao Doacao { get; set; }
        public string StatusDaDoacao { get; set; }
        public string Comprovante { get; set; }
        public decimal ValorDaDoacao { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;
        // Navigation property
        public Doador Doador { get; set; }
    }
}