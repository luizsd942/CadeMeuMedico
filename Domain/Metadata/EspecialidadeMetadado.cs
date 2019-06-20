using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Metadata
{
    [MetadataType(typeof(EspecialidadeMetadado))]
    public partial class Especialidade
    {

    }
    class EspecialidadeMetadado
    {
        [Required(ErrorMessage ="O campo Nome é Obrigatório")]
        [StringLength(80,ErrorMessage ="O Nome deve possuir no máximo 80 caracteres.")]
        public string Nome { get; set; }
    }
}
