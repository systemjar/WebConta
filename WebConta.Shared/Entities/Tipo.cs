using System.ComponentModel.DataAnnotations;

namespace WebConta.Shared.Entities
{
    public class Tipo
    {
        public int Id { get; set; }

        [Display(Name = "Tipo Documento")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null!;
    }
}
