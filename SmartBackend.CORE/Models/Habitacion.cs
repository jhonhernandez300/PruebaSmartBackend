using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.CORE.Models
{
    public class Habitacion
    {
        public required string HabitacionId { get; set; }
        public required int Numero { get; set; }
        public required decimal CostoBase { get; set; }
        public required decimal Impuesto { get; set; }
        public required int Tamaño { get; set; }
    }
}
