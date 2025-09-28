

namespace SGRH.Domain.Entities.Configuration
{
    public sealed class Clientes : Base.BaseEntity
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
