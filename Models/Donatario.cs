using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SisDoBem.Models
{
    public class Donatario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(250)]
        public string Descricao { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }  
        public string Endereco { get; set; }
        public string TipoDeDoacao { get; set; } // Material/Valor
        public decimal ValorRecebido { get; set; }
        public decimal RendaMensal { get; set; }
        public string Observacoes { get; set; }
        public string Status { get; set; } // Ativo/Inativo
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;
        public DateTime DataDeAtualizacao { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return Nome;
        }
    }
}