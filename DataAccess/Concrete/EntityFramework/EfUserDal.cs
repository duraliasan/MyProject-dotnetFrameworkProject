using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, DatabaseContext>, IUserDal
    {
        public List<Role> GetClaims(User user)
        {
            using (var context = new DatabaseContext())
            {
                var result = from role in context.Roles
                             join userRoleClaim in context.UserRoleClaims
                             on role.RoleID equals userRoleClaim.RoleID
                             where userRoleClaim.UserID == user.UserID
                             select new Role { RoleID = role.RoleID, RoleName = role.RoleName };
                return result.ToList();
            }
        }
    }
}