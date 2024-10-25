using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Cart : IEntity
    {
        [Key]
        public int CartID { get; set; }
        public int CustomerID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; } = false;
    }
}