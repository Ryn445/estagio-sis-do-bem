namespace SisDoBem.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; } //CPF ou CNPJ
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public TipoCadastro TipoUsuario { get; set; } // Exemplo: "Doador", "Beneficiario", "Administrador", "Colaborador", "Voluntario", "EmpresaParceira"
        public string Endereco { get; set; }
        public string Referencia { get; set; }
        public string Bairro  { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }



    }
}
