using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Quality : IEntity
    {
        [Key]
        public int QualityID { get; set; }
        public string QualityName { get; set; }
    }
}