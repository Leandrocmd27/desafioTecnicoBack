using System.ComponentModel.DataAnnotations;

namespace desafioTecnicoBack.Models
{
    public class Convenio
    {
        [Key]
        public int ConvenioId { get; set; }

        [StringLength (250)]
        public string NomeConvenio { get; set; }
    }
}
