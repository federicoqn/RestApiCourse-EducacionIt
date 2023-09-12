using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEF.Models
{
    [Table("Autor")]
    public class Autor
    {
        [Key]
        public int IdAutor { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        public string Cuidad { get; set; }

        public List<Libro> Libros { get; set; }


    }
}
