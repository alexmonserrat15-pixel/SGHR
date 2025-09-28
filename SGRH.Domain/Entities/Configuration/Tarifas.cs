

namespace SGRH.Domain.Entities.Configuration
{
    public sealed class Tarifas : Base.BaseEntity
    {
        public int TarifaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal PrecioPorNoche { get; set; }
    }
}
