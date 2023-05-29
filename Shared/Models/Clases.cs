using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Clases
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Fecha es requerido.")]

        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El campo Encargado es requerido.")]
        public string Encargado { get; set; }
        [Required(ErrorMessage = "El campo ClientesId es requerido.")]

        public int ClientesId { get; set; }

        public virtual Clientes? Clientes { get; set; }
    }
}
