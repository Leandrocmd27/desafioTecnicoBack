namespace desafioTecnicoBack.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Genero { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? UFRG { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? TelefoneFixo { get; set; }
        public int ConvenioId { get; set; }
        public Convenio? Convenio { get; set; }
        public string? NumeroCarteirinha { get; set; }
        public string? ValidadeCarteirinha { get; set; }

    }
}
