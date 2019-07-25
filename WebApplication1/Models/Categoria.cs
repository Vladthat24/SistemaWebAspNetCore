using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Categoria
    {   
       
        public int CategoriaID { get; set; }
        
        [Required(ErrorMessage ="Campo requerido")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El nombre deb de tener de 3 a 50 caracteres")]
        public string Nombre { get; set; }

        [StringLength(256)]
        [Display(Name ="Descripcíon")]
        public string Descripcion { get; set; }

        [Required]
        public Boolean Estado { get; set; }



    }
}
