using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestDB.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "El campo 'Name' es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo 'Name' no debe tener más de 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo 'IdentificationType' es obligatorio.")]
        public string IdentificationType { get; set; }

        [Required(ErrorMessage = "El campo 'Identification' es obligatorio.")]
        public string IdentificationNumber { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public long DateOfBirth { get; set; }
    }
}
