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
   public interface ISubCategoryDal:IEntityRepository<SubCategoory>
    {

        List<SubCategoryListDto> GetCtegoryListDal();

      SubCategoryListDto GetCtegoryGetByIdDal(int id);

    }
}
