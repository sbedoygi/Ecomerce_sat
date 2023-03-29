using System.ComponentModel.DataAnnotations;

namespace Ecommerce_SAt.DAL.Entities
{
    public class Entity
    {
        [Key]
        public virtual Guid Id { get; set; }

        public virtual string CreatedDate { get; set; }
        public virtual string ModifiedDate { get; set;}


    }
}
