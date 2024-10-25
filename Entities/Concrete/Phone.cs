using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Phone : IEntity
    {
        [Key]
        public int PhoneID { get; set; }
        public string PhoneNumber { get; set; }
        public bool isEnable { get; set; }
        public bool sendMessage { get; set; }
    }
}