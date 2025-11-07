



using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SisDoBem.Models
{
    public class Doador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }  
        public string Endereco { get; set; }
        public enum TipoDeDoacao { get; set; } = Material/Valor
        public DateTime DataDaDoacao { get; set; }
        public decimal ValorDaDoacao { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;

    }
}

