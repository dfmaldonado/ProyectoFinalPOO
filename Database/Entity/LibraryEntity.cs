using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProyectoFinal.Database.Entity.Common;

namespace ProyectoFinal.Database.Entity
{
    //Tabla para Ingresar los Datos de los Libros
    [Table("Library")]
    public class LibraryEntity : BaseEntity
    {
        [Column("book_name")]
        [Required]
        public string BookName { get; set; }

        [Column("author")]
        [Required]
        public string Author { get; set; }

        [Column("type")]
        [Required]
        public string Type { get; set; }

        [Column("volume")]
        [Required]
        public int Volume { get; set; }

        [Column("publisher")]
        [Required]
        public string Publisher { get; set; }

        [Column("publication_date")]
        [Required]
        public DateTime PublicationDate { get; set; }

    }
}
