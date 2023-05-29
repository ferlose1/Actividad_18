using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Clientes
    {
        public int? id {get; set;}
        public string? nombre { get; set; }
        public string? direccion { get; set; }
        public string? telefono { get; set; }
        public string? correo { get; set; }
        public DateTime? fnacimiento { get; set; }
        
        public virtual ICollection<Clases>? Clases { get; set; }
        public virtual ICollection<Medidas>? Medidas { get; set; }
    }
}

