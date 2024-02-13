using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.CORE.Models
{
    public class ContactoDeEmergencia
    {
        public int ContactoDeEmergenciaId { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public required string Genero { get; set; }
        public required string TipoDeDocumento { get; set; }
        public required int NumeroDeDocumento { get; set; }
        public required string Email { get; set; }
    }
}
