using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class ImageUrl : IEntity
    {
        [Key]
        public int ImageID { get; set; }
        public string ImageURL { get; set; }
        public string ImageDescription { get; set; }
    }
}