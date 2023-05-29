using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Clientes
    {
        public int? id {get; set;}
//        [Required(ErrorMessage = "El campo Nombre es requerido.")]

        public string? nombre { get; set; }
        [Required(ErrorMessage = "El campo Direccion es requerido.")]

        public string? direccion { get; set; }
        [Required(ErrorMessage = "El campo Telefono es requerido.")]

        public string? telefono { get; set; }
        [Required(ErrorMessage = "El campo Correo es requerido.")]

        public string? correo { get; set; }
        [Required(ErrorMessage = "El campo Nacimiento es requerido.")]

        public DateTime? fnacimiento { get; set; }
        
        public virtual ICollection<Clases>? Clases { get; set; }
        public virtual ICollection<Medidas>? Medidas { get; set; }
    }
}

