using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Email : IEntity
    {
        [Key]
        public int EmailID { get; set; }
        public string EmailEmail { get; set; }
        public bool IsEnable { get; set; } = true;
        public bool SendMessage { get; set; } = false;
    }
}