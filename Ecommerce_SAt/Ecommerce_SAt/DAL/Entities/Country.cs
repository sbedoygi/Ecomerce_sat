using System.ComponentModel.DataAnnotations;

namespace Ecommerce_SAt.DAL.Entities
{
    public class Country:Entity  
    {
        [Display(Name ="Pais")]
        [MaxLength(50)]// varchar(50)
        [Required(ErrorMessage =" el campo {0} es requerido")] // se ignifica el not null 
        public string Name { get; set; }




    }
}
