namespace SisDoBem.Models.Enums
{
    public enum TipoDeDoacao { Dinheiro, Roupa, Brinquedo, Alimento, Outro }

    public enum StatusDaCampanha { Ativa, Concluida, Cancelada }
    public enum StatusUsuario { Ativo, Inativo }

    public enum TipoDeUsuario { Administrador, DoadorCnpj, DoadorCpf, Donatario, Voluntario }
    public enum MeioDeDoacao { Online, Presencial }
}
