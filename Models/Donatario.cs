using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SisDoBem.Models.Enums;

namespace SisDoBem.Models
{
    public class Donatario
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal RendaMensal { get; set; }
        public int MembrosFamilia { get; set; }
        public string Observacoes { get; set; }
    }
}