using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
    }
}
