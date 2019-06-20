using System.ComponentModel.DataAnnotations;

namespace Domain.Metadata
{
    [MetadataType(typeof(MedicoMetadado))]
    public partial class Medico
    {

    }
    class MedicoMetadado
    {
        [Required(ErrorMessage ="O campo CRM é obrigatório")]
        public string CRM { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo Nome deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }
        [StringLength(100, ErrorMessage = "O Endereço deve possuir no máximo 100 caracteres.")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string Bairro { get; set; }
        [StringLength(80, ErrorMessage = "O Email deve possuir no máximo 80 caracteres.")]
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "É obrigatório informar se Tem Clínica")]
        public bool AtendePorConvenio { get; set; }
        [Required(ErrorMessage = "É obrigatório informar se Atende por Convênio")]
        public bool TemClinica { get; set; }
        [StringLength(80, ErrorMessage = "O Website deve possuir no máximo 80 caracteres.")]
        public string WebsiteBlog { get; set; }
        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        public int IDCidade { get; set; }
        [Required(ErrorMessage = "O campo Especialidade é obrigatório")]
        public int IDEspecialidade { get; set; }
    }
}