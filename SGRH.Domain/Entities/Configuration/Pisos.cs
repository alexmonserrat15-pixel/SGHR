

namespace SGRH.Domain.Entities.Configuration
{
    public sealed class Pisos : Base.BaseEntity
    {
        public int PisoId { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
