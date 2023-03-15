using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrameWorkTenatativa_1.Models
{
    public class Departaments
    {
        [Key]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório !!!")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }

    }
}