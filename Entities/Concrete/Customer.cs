using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public DateOnly? CustomerBirthOfDate { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public bool IsEnable { get; set; } = true;
        public byte[] customerPasswordHash { get; set; }
        public byte[] customerPassword { get; set; }
    }
}