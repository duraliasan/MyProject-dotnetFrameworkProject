﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products 
                             join c in context.Categories 
                             on p.CategoryID equals c.CategoryID 
                             select new ProductDetailDto
                {
                    ProductID = p.ProductID, 
                    ProductName = p.ProductName, 
                    CategoryName = c.CategoryName, 
                    UnitsInStock = p.UnitsInStock
                };

                return result.ToList();
            }
        }
    }
}
