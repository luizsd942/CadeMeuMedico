using System.ComponentModel.DataAnnotations;

namespace Domain.Metadata
{
    [MetadataType(typeof(Usuario))]
    public partial class Usuario
    {

    }
    class UsuarioMetadado
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo Nome deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Login é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Login deve possuir no máximo 50 caracteres")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [StringLength(15, ErrorMessage = "O campo Senha deve possuir no máximo 15 caracteres")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo Email deve possuir no máximo 80 caracteres")]
        public string Email { get; set; }
    }
}
