using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    [Table("Categoria", Schema ="Cat")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage ="Se debe definir el nombre de la categoría.")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public DateTime FechaCreo { get; set; }
    }
}
