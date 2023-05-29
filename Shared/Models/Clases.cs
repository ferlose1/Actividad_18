using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Clases
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public string Encargado { get; set; }
        public int ClientesId { get; set; }
        public virtual Clientes? Clientes { get; set; }
    }
}
