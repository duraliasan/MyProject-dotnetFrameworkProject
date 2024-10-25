using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        [Key]
        public int AddressID { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public int NeighborhoodID { get; set; }
        public string AddressName { get; set; }
    }
}