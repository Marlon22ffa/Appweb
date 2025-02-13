using System.ComponentModel.DataAnnotations;

namespace ApiProductos.Models
{
    public class Producto
    {
        public int Id { get; set; } // Clave primaria autoincremental

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal Precio { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo.")]
        public int Stock { get; set; }
    }
}
