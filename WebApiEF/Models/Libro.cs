using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEF.Models
{
    [Table("Libro")]
    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Titulo { get; set; }

        public int AutorId { get; set; }

        public Autor Autor { get; set; }

    }
}
