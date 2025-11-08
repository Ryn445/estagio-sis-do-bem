using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SisDoBem.Models.Enums;

namespace SisDoBem.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; } // CPF ou CNPJ
        public string Email { get; set; }
        public string Telefone { get; set; }  
        public string Endereco { get; set; }
        public DateTime DataDeCadastro { get; set; } = DateTime.Now;
        public TipoDeUsuario TipoDeUsuario { get; set; }
        public StatusUsuario Status { get; set; } = StatusUsuario.Ativo;

    }
}

