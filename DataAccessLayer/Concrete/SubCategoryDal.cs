using CoreLayer.DataAccess.EntityFramwork;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class SubCategoryDal : BaseRepository<SubCategoory, ProjeContext>, ISubCategoryDal
    {
        public SubCategoryListDto GetCtegoryGetByIdDal(int id)
        {
            using (var context = new ProjeContext())
            {
                var subCategory = context.SubCategoories
            .Where(s => s.Id == id)
            .Select(s => new SubCategoryListDto
            {
                Id = s.Id,
              
            
            })
            .FirstOrDefault();

                return subCategory;
            }
        }
        public List<SubCategoryListDto> GetCtegoryListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.SubCategoories.Select(subCategory => new SubCategoryListDto()
                {
                   // Name=subCategory.Id,
                    Id = subCategory.Id,
            Name=subCategory.TopCattegory.Name,
             ImageUrl=subCategory.Cattegory.ImageUrl,
             Description=subCategory.Description,
             Date= subCategory.Date,
             Price=subCategory.Cattegory.Price,
             isActive=subCategory.Cattegory.isActive,
             TopCattegoryName=subCategory.TopCattegory.Name,
             CattegoryName=subCategory.TopCattegory.Name,
            
                });
                return a.ToList();
            }
        }
    }
}
