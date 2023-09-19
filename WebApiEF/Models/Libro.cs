using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiEF.Helper;

namespace WebApiEF.Models
{
    [Table("Libro")]
    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }

        [TestLibroValidationAttribute]
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Titulo { get; set; }

        public int AutorId { get; set; }

        public Autor Autor { get; set; }

    }
}
