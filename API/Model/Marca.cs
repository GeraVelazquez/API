using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    [Table("Marca", Schema = "Cat")]
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }
        [Required(ErrorMessage = "Se debe definir el nombre de la marca.")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}
