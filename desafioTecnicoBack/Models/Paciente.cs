using System.ComponentModel.DataAnnotations;

namespace desafioTecnicoBack.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }
        [StringLength(50)]
        public string? Nome { get; set; }
        [StringLength(250)]
        public string? SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        [StringLength(2)]
        public string? Genero { get; set; }
        [StringLength(15)]
        public string? CPF { get; set; }
        [StringLength(15)]
        public string? RG { get; set; }
        [StringLength(2)]
        public string? UFRG { get; set; }
        [StringLength(150)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Celular { get; set; }
        [StringLength(20)]
        public string? TelefoneFixo { get; set; }
        public int ConvenioId { get; set; }
        public Convenio? Convenio { get; set; }
        [StringLength(20)]
        public string? NumeroCarteirinha { get; set; }
        [StringLength(6)]
        public string? ValidadeCarteirinha { get; set; }
        public bool? Ativo { get; set; }

    }
}
