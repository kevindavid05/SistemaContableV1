using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable.Modelos
{
    public class Cliente
    {
        [Key]
        public int ClId { get; set; }


        [Required(ErrorMessage = "Nombre del cliente es requerido")]
        [MaxLength(60, ErrorMessage ="Máximo de longitud para nombre cliente es de 60")]
        public string Clnombre { get; set; }

        [Required(ErrorMessage = "Direccion es requerido")]
        [MaxLength(80, ErrorMessage = "Máximo de longitud para direccion es de 60")]
        public string Cldireccion { get; set; }
        public int Cltelefono { get; set; }
        public string Clemail { get; set; }
        public string Clnit { get; set; }
    }
}
