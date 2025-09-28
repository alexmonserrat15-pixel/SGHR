

namespace SGRH.Domain.Entities.Configuration
{
    public sealed class HistorialReservas : Base.BaseEntity
    {
        public int HistorialReservaId { get; set; }
        public int ReservaId { get; set; }
        public DateTime FechaCambio { get; set; }
        public string EstadoAnterior { get; set; } = null!;
        public string EstadoNuevo { get; set; } = null!;
        public string? Comentarios { get; set; }
    }
}
