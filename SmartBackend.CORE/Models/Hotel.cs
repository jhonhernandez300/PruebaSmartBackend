using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.CORE.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public required string Nombre { get; set; }
        public required string Direccion { get; set; }
        public required string Habilitado { get; set; }
        public required string Ciudad { get; set; }
    }
}
