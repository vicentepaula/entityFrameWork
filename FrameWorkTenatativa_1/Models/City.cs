using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FrameWorkTenatativa_1.Models
{
    public class City
    {

        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório !!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório !!!")]

        [Range(1, double.MaxValue, ErrorMessage = "Selecione um Departamento")]
        public int DepartamentsId { get; set; }

        public virtual Departaments Departament { get; set; }
    }
}