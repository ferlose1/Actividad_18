using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Medidas
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido.")]

        public string NombreCliente { get; set; }
        [Required(ErrorMessage = "El campo Peso es requerido.")]

        public double peso { get; set; }
        [Required(ErrorMessage = "El campo Altura es requerido.")]

        public double altura { get; set; }
        [Required(ErrorMessage = "El campo Cintura es requerido.")]

        public double cintura { get; set; }
        [Required(ErrorMessage = "El campo Porcentaje es requerido.")]

        public double porcentajeD {get; set; }
        [Required(ErrorMessage = "El campo CLientesId es requerido.")]


        public int CLientesId { get; set; }
        public virtual Clientes? Clientes { get; set; }
    }
}
