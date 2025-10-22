using System;
using System.componentModel.DataAnnotations;

namespace SistemaONG.Models
{
    public class Doacao
    {
        public int Id { get; set; }
        [Required]
        public string TipoDeDoacao { get; set; } // Material/Valor
        public decimal ValorDaDoacao { get; set; }
        public string Descricao { get; set; }
        public string MeioDeDoacao { get; set; } // Online, Presencial
        public string Comprovante { get; set; } // URL ou caminho do arquivo
        public int? CampanhaId { get; set; }
        public Campanha Campanha { get; set; }
        public int DoadorId { get; set; }
        public Doador Doador { get; set; }
        public int? DonatarioId { get; set; }
        public Donatario Donatario { get; set; }
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;
        public DateTime DataDeAtualizacao { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"{TipoDeDoacao} - {ValorDaDoacao:C}";
        }

    }
}