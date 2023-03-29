using System.ComponentModel.DataAnnotations;

namespace Ecommerce_SAt.DAL.Entities
{
    public class Entity
    {
        [Key]
        public virtual Guid Id { get; set; }
        [Display(Name = "Fecha De creacion")]
        public virtual DateTime? CreatedDate { get; set; }
        [Display(Name = "Facha de Modificacion")]
        public virtual DateTime? ModifiedDate { get; set;}


    }
}
