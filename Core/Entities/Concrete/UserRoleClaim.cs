namespace Core.Entities.Concrete
{
    public class UserRoleClaim : IEntity
    {
        public int UserRoleClaimID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
    }
}
