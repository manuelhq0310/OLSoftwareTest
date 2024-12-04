using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'ProductName' es obligatorio.")]
        [MaxLength(200, ErrorMessage = "El campo 'ProductName' no debe tener más de 200 caracteres.")]
        public string ProductName { get; set; }

        public string Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El campo 'Price' debe ser mayor que 0.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El campo 'Stock' no puede ser negativo.")]
        public int Stock { get; set; }
                
        public long ExpirationDate { get; set; }
    }
}
