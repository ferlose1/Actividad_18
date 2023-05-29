using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Medidas
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
        public double cintura { get; set; }
        public double porcentajeD {get; set; }

        public int CLientesId { get; set; }
        public virtual Clientes? Clientes { get; set; }
    }
}
