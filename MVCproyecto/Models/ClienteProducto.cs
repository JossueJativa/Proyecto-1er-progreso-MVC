using System.ComponentModel.DataAnnotations;

namespace MVCproyecto.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [StringLength(11)]
        public string? cedula { get; set; }
        [StringLength(75)]
        public string? nombre { get; set; }
        [StringLength(75)]
        public string? apellido { get; set; }
        public int edad { get; set; }
        [StringLength(75)]
        public string? correo { get; set; }
    }

    public class Producto
    {
        public int Id { get; set; }
        [StringLength(75)]
        public string? codigo { get; set; }
        [StringLength(75)]
        public string? nombre { get; set; }
        [StringLength(75)]
        public string? descripcion { get; set; }
        public double valor { get; set; }
        public int cantidad { get; set; }
    }
}
