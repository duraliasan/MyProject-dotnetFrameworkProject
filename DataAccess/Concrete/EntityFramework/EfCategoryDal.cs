using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, DatabaseContext>, ICategoryDal
    {
        public List<CategoryDetailDto> GetCategoryDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.Categories
                             //join i in context.ImageUrls
                             //on c.CategoryID equals i.ImageID
                             select new CategoryDetailDto
                             {
                                 CategoryID = c.CategoryID,
                                 CategoryName = c.CategoryName,
                                 //CategoryImage = i.ImageURL,
                                 CategoryDescription = c.CategoryDescription,
                             };

                return result.ToList();
            }
        }
    }
}