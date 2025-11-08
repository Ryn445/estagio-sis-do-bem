namespace SisDoBem.Models
{
    public class Saida
    {
        public int Id { get; set; }
        public DateTime DataDaSaida { get; set; } = DateTime.Now;
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public int DonatarioId { get; set; }
    }
}
