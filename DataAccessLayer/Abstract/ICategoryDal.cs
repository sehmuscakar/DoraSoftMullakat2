using CoreLayer.DataAccess;
using DataAccessLayer.Dtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
    {
        List<Category> GetCategroyByFilterDal(string Name , decimal? Price , string isActive);

        List<CategoryListDto> GetCtegoryListDal();
    }
}
