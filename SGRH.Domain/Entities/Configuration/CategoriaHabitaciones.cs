

namespace SGRH.Domain.Entities.Configuration
{
    public sealed class CategoriaHabitaciones : Base.BaseEntity
    {
    public int IdCategoriaHabitacion { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }

    }
}
