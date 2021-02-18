using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConcesionariaSystem.Models
{
    public class Autos : EntityBase
    {
        [Required(ErrorMessage = "El campo Marca del auto no puede estar vacío")]
        [MinLength(2)]
        [MaxLength(10)]
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El campo Modelo no puede estar vacío")]
        [MinLength(20)]
        [MaxLength(60)]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        public string Año { get; set; }

        public int Existencias { get; set; }
    }
}
