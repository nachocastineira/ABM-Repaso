using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Parcial2.Models
{
    public class EmpleadoMetadata
    {
        [Required]
        [RegularExpression(@"^([^<>]){1,50}$", ErrorMessage = "Este campo {0} es obligatorio y tiene un máximo de 50 caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [RegularExpression(@"^([^<>]){1,50}$", ErrorMessage = "Este campo {0} es obligatorio y tiene un máximo de 50 caracteres.")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required]
        [Display(Name = "Edad")]
        public Nullable<int> Edad { get; set; }
    }
}