using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.CORE.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public required DateTime FechaInicio { get; set; }
        public required DateTime FechaSalida { get; set; }
        public required int CantidadDePersonas { get; set; }
    }
}
