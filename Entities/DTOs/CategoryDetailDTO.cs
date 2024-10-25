using Core.Entities;

namespace Entities.DTOs
{
    public class CategoryDetailDto : IDto 
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }
    }
}
